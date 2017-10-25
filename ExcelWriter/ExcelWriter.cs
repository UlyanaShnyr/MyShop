using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopWorkWithDB;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace ExcelWriter
{
    public class ExcelWriter
    {
        public static List<string> tableHeaders = new List<string>() {
            "Id","SaleDate","Sum","Count","Id","Name","Price","DiscountId","DiscountDescription","DiscountPercent","TypeId","TypeName"
        };

        static public void WriteToExcel(List<Sale> sales, string path)
        {
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                new Exception("Excel is not property installed");
            }


            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;

            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < tableHeaders.Count; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = tableHeaders[i];
            }


            Excel.Range oRange;
            int pos = 2;
            int countProds;
            for (int i = 0; i < sales.Count; i++)
            {
                xlWorkSheet.Cells[pos, 1] = sales[i].Id;
                xlWorkSheet.Cells[pos, 2] = sales[i].SaleDate.ToString("u");
                xlWorkSheet.Cells[pos, 3] = sales[i].Sum;
                xlWorkSheet.Cells[pos, 4] = sales[i].SaledProducts.Count;

                for (int j = 0; j < sales[i].SaledProducts.Count; j++)
                {
                    xlWorkSheet.Cells[pos, 5] = sales[i].SaledProducts[j].Id;
                    xlWorkSheet.Cells[pos, 6] = sales[i].SaledProducts[j].Name;
                    xlWorkSheet.Cells[pos, 7] = sales[i].SaledProducts[j].Price;
                    xlWorkSheet.Cells[pos, 8] = sales[i].SaledProducts[j].Discount.Id;
                    xlWorkSheet.Cells[pos, 9] = sales[i].SaledProducts[j].Discount.Description;
                    xlWorkSheet.Cells[pos, 10] = sales[i].SaledProducts[j].Discount.Percent;
                    xlWorkSheet.Cells[pos, 11] = sales[i].SaledProducts[j].Type.Id;
                    xlWorkSheet.Cells[pos, 12] = sales[i].SaledProducts[j].Type.Name;
                    ++pos;
                }
                countProds = sales[i].SaledProducts.Count;

                for (int g = 1; g <= 4; g++)
                {
                    oRange = xlWorkSheet.Range[xlWorkSheet.Cells[pos - countProds, g], xlWorkSheet.Cells[pos - 1, g]];

                    (xlWorkSheet.Cells[pos - countProds, g] as Excel.Range).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    (xlWorkSheet.Cells[pos - countProds, g] as Excel.Range).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                    oRange.Merge(Type.Missing);
                }


                ++pos;
            }




            xlWorkBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

        }
    }
}
