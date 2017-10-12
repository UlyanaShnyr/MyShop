using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Admin : Form
    {
        
        public Admin(Login mainForm)
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProduct ad;
            ad = new AddProduct();
            ad.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login m;
            m = new Login();
            this.Hide();
            m.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Registr r;
            r = new Registr();         
            r.ShowDialog();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.TextChanged -= textBox4_TextChanged;
            textBox4.ForeColor = Color.Black;
        }
    }
}
