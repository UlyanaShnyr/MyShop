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
        TicketModel model;
        Label[] lables;
        Label[] lablesPrice;
        Label[] lablesCount;

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
            for (int i = 0; i < model.Products.Count; i++)
            {
                sw.WriteLine(String.Format("   {0}                {1}   {2}", lables[i].Text, lablesPrice[i].Text, lablesCount[i].Text));
            }
            sw.WriteLine(String.Format("   {0}                {1}", nimber.Text, priceforOneProducts.Text));
            sw.WriteLine("    ******************************    ");
            sw.WriteLine();
            sw.WriteLine(String.Format("  Загальна сума: {0} ", TotalPrice.Text));
            sw.WriteLine();
            sw.WriteLine("           м.Львів, вул.Пекарська, 10    ");
            sw.WriteLine("              +3 (022) 296-54-85    ");

            sw.Close();
        }

        public Ticket(TicketModel model)
        {
            InitializeComponent();
             path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            path += "/bill.txt";
            this.model = model;
            hour.Text = DateTime.Now.ToShortTimeString();
            cashiersName.Text = model.Cashier;
            score.Text = "100111";
            day.Text = DateTime.Now.ToShortDateString();
            nimber.Text = model.Products.Count.ToString();

            
            lables = new Label[model.Products.Count];
            lablesPrice = new Label[model.Products.Count];
            lablesCount = new Label[model.Products.Count];

             int y=0;
            for (int i = 0; i < model.Products.Count; i++)
            {
                lables[i] = new Label();
                lables[i].Location = new Point(10, 205+y);
                lables[i].Text = model.Products[i].Product;
                panel1.Controls.Add(lables[i]);

                lablesPrice[i] = new Label();
                lablesPrice[i].Location = new Point(230, 205 + y);
                lablesPrice[i].Text = model.Products[i].price.ToString();
                panel1.Controls.Add(lablesPrice[i]);


                lablesCount[i] = new Label();
                lablesCount[i].Location = new Point(280, 205 + y);
                lablesCount[i].Text = model.Products[i].count.ToString();
                panel1.Controls.Add(lablesCount[i]);

                y += 10;
            }
            nimber.Location = new Point(10, 272 + y);
            label9.Location = new Point(35, 297 + y);
            label10.Location = new Point(3, 322 + y);
            TotalPrice.Location = new Point(117, 316 + y);
            label11.Location= new Point(101,348+y);
            label12.Location = new Point(114, 370 + y);
            Print.Location = new Point(56, 412 + y);
            Back.Location = new Point(188, 412 + y);

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

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }

}
