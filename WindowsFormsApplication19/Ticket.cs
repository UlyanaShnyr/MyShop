using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Ticket : Form
    {
        string path;

        public void PrintCheck() {
           
            StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
            sw.WriteLine("          \"SportsEat\"");
            sw.WriteLine("   Магазин спотивних добавок");
            sw.WriteLine();
            sw.WriteLine();
            sw.WriteLine(String.Format("  Час:   {0} ", hour.Text));
            sw.WriteLine(String.Format("  Касир:   {0} ", cashiersName.Text));
            sw.WriteLine(String.Format("  Рахунок №  {0} ", score.Text));
            sw.WriteLine("    ******************************    ");
            sw.WriteLine(String.Format("  Дата:   {0} ", day.Text));
            sw.WriteLine(String.Format("   {0}                {1}", ProductsName.Text, numbers.Text));
            sw.WriteLine(String.Format("   {0}                {1}", nimber.Text, priceforOneProducts.Text));
            sw.WriteLine("    ******************************    ");
            sw.WriteLine();
            sw.WriteLine(String.Format("  Загальна сума: {0} ", TotalPrice.Text));
            sw.WriteLine();
            sw.WriteLine("           м.Львів, вул.Пекарська, 10    ");
            sw.WriteLine("              +3 (022) 296-54-85    ");

            sw.Close();
        }


        public Ticket()
        {
            InitializeComponent();
            path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path += "/bill.txt";
        }

        private void Sale_Click(object sender, EventArgs e)
        {

        }

        private void ProductsName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

            this.Hide();
            
        }

        private void Print_Click(object sender, EventArgs e)
        {

            PrintCheck();
            MessageBox.Show("check directory:   "+ path);

        }
    }

}
