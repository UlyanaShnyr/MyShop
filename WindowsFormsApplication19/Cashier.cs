using System;
using System.Windows.Forms;
using ShopWorkWithDB;


namespace WindowsFormsApplication19
{
    public partial class Cashier : Form
    {
        ShopDbService dbService;
        User user;

        public Cashier(ShopDbService dbService, User user)
        {
            InitializeComponent();
            this.dbService = dbService;
            this.user = user;
            textBoxCashierName.Text = string.Format("{0} {1}", user.Name, user.Surname);

        }

        private void Check_Click(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {           
            
                    
        }   

       

        
    }
}
