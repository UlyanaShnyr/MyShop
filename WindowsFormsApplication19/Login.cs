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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string c = "1";
            string a = "2";
            if (textBox1.Text == c)
            {
                Cashier f2;
                f2 = new Cashier(this);
                this.Hide();
                f2.ShowDialog();
            }
            if (textBox1.Text == a)
            {
                Admin f3;
                f3 = new Admin(this);
                this.Hide();
                f3.ShowDialog();
            }
            
          
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
           // textBox1.Text = "";
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
           textBox1.Text = "";
           textBox1.TextChanged -= textBox1_TextChanged;
           textBox1.ForeColor = Color.Black;
        
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.TextChanged -= textBox2_TextChanged;
            textBox2.ForeColor = Color.Black;
        }

  
    }
}
