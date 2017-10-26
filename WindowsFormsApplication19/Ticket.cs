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
        string path = "printedbill.txt";
        public Ticket()
        {
            InitializeComponent();
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
            //  StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default);
            //  sw.WriteLine("    SportsEat");

            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine("text");
            }

            using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("Дозапись");
                sw.Write(4.5);
            }
        }
    }
}
