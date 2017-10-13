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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ProductsName_TextChanged(object sender, EventArgs e)
        {
            ProductsName.Text = "";
            ProductsName.TextChanged -= ProductsName_TextChanged;
            ProductsName.ForeColor = Color.Black;
        }

        private void Number_TextChanged(object sender, EventArgs e)
        {
            Number.Text = "";
            Number.TextChanged -= Number_TextChanged;
            Number.ForeColor = Color.Black;
        }

        private void Action_TextChanged(object sender, EventArgs e)
        {
            Action.Text = "";
            Action.TextChanged -= Action_TextChanged;
            Action.ForeColor = Color.Black;
        }

        private void Price_TextChanged(object sender, EventArgs e)
        {
            Price.Text = "";
            Price.TextChanged -= Price_TextChanged;
            Price.ForeColor = Color.Black;
        }
    }
}
