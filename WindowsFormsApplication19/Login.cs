using System;
using ShopWorkWithDB;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Login : Form
    {
        ShopDbService dbService;

        public Login()
        {
            InitializeComponent();
            dbService = new ShopDbService();            
        }

        private void SportsEat_Click(object sender, EventArgs e)
        {

        }
              

        private void Enter_Click(object sender, EventArgs e)
        {
            string c = "1";
            string a = "2";
            if (LoginName.Text == c)
            {
                Cashier f2;
                f2 = new Cashier(dbService);
                this.Hide();
                f2.ShowDialog();
            }
            if (LoginName.Text == a)
            {
                Admin f3;
                f3 = new Admin(dbService);
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

        private void LoginName_Enter(object sender, EventArgs e)
        {

            // textBox1.Text = "";

        }

        private void LoginName_TextChanged(object sender, EventArgs e)
        {
           
           LoginName.Text = "";
           LoginName.TextChanged -= LoginName_TextChanged;
           LoginName.ForeColor = Color.Black;
        
           
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.TextChanged -= Password_TextChanged;
            Password.ForeColor = Color.Black;
        }

        private void labelshop_Click(object sender, EventArgs e)
        {

        }

  
    }
}
