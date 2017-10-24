using System;
using System.Drawing;
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
            dbService.DB.Users.Add(new User() { Login = "Admin", Name = "Ura", Surname = "Melenuk", Password = "111", Phone = "empty", Role = "Admin" });
            dbService.DB.SaveChanges();
        }

        private void SportsEat_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Метод обробник входу Користувачів та адмінів
        /// Відповідно до ролі відкриває відповідну форму
        /// </summary>                 

        private void Enter_Click(object sender, EventArgs e)
        {
            User user = dbService.CheckingUser(LoginName.Text, Password.Text);
            if(user == null)
            {                
                MessageBox.Show("Wrong Login or Password");
            }     
            else
            {
                this.Hide();                
                switch (user.Role)
                {
                    case "Admin":
                        new Admin(dbService, user).ShowDialog();
                        break;
                    case "Cashier":
                        new Cashier(dbService, user).ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Something went wrong");
                        break;
                }
                this.Show();
            }
            LoginName.Text = Password.Text = "";
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
