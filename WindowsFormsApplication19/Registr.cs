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
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Hide();
         
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.TextChanged -= textBox4_TextChanged;
            textBox4.ForeColor = Color.Black;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.TextChanged -= textBox3_TextChanged;
            textBox3.ForeColor = Color.Black;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.TextChanged -= textBox5_TextChanged;
            textBox5.ForeColor = Color.Black;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.TextChanged -= textBox6_TextChanged;
            textBox6.ForeColor = Color.Black;
        }
    }
}
