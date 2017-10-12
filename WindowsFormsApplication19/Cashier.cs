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
    public partial class Cashier : Form
    {
        Login mainForm;
        public Cashier(Login mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }



        private void button3_Click(object sender, EventArgs e)
        {

            Ticket f4;
            f4 = new Ticket();
            f4.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            mainForm.Show();

          
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
