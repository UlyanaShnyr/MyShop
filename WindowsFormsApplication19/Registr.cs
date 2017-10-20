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

        private void Registration_Click(object sender, EventArgs e)
        {
          
            this.Hide();
         
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            Name.Text = "";
            Name.TextChanged -= Name_TextChanged;
            Name.ForeColor = Color.Black;
        }

        private void Surname_TextChanged(object sender, EventArgs e)
        {
            Surname.Text = "";
            Surname.TextChanged -= Surname_TextChanged;
            Surname.ForeColor = Color.Black;
        }

        private void PhoneNumber_TextChanged(object sender, EventArgs e)
        {
            PhoneNumber.Text = "";
            PhoneNumber.TextChanged -= PhoneNumber_TextChanged;
            PhoneNumber.ForeColor = Color.Black;
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {
            Login.Text = "";
            Login.TextChanged -= Login_TextChanged;
            Login.ForeColor = Color.Black;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.TextChanged -= Password_TextChanged;
            Password.ForeColor = Color.Black;
        }

        private void  againpassword_TextChanged(object sender, EventArgs e)
        {
            againpassword.Text = "";
            againpassword.TextChanged -= againpassword_TextChanged;
            againpassword.ForeColor = Color.Black;
        }
    }
}
