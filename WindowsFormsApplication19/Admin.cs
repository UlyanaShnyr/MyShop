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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProduct ad;
            ad = new AddProduct();
            ad.ShowDialog();
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Login m;
            m = new Login();
            this.Hide();
            m.Show();

        }

        private void CashierRegisteration_Click(object sender, EventArgs e)
        {
            Registr r;
            r = new Registr();         
            r.ShowDialog();
        }

        private void AdminName_TextChanged(object sender, EventArgs e)
        {
            AdminName.Text = "";
            AdminName.TextChanged -= AdminName_TextChanged;
            AdminName.ForeColor = Color.Black;
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {

        }

        private void ListProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
