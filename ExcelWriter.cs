using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;


namespace ExcelWriter
{
    public class ExcelWriter
    {
        private static PropertyInfo[] GetPropertys(Object obj)
        {
            Type t = obj.GetType();
            return t.GetProperties();
        }

        static public void WriteToExcel(Object[] objects, string path)
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


            PropertyInfo[] prop = GetPropertys(objects[0]);
            for (int i = 0; i < prop.Length; i++)
            {
                xlWorkSheet.Cells[1, i + 1] = prop[i].Name;
            }

            for (int i = 0; i < objects.Length; i++)
            {
                for (int j = 0; j < prop.Length; j++)
                {
                    xlWorkSheet.Cells[i + 2, j + 1] = prop[j].GetValue(objects[i]);
                }

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
