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
    }
}
