using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WcfService1;


namespace WindowsFormsApplication19
{
    public partial class Cashier : Form
    {
       
        Login mainForm;
        //ShopDB service = new ShopDB("feefe");
        
        public Cashier(Login mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
           
            
        }



        private void Check_Click(object sender, EventArgs e)
        {

            Ticket f4;
            f4 = new Ticket();
            f4.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            mainForm.Show();

          
        }

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void Actions_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CashierName_TextChanged(object sender, EventArgs e)
        {
            //User u = new User();
            //textBox4.Text = u.Name.ToString();
        }
    }
}
