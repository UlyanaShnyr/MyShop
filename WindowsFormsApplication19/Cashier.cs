using System;
using System.Windows.Forms;
using ShopWorkWithDB;
using System.Collections.Generic;


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

            List<ProductType> types = dbService.GetProductTypes();
            for(int i=0; i<types.Count; i++)
            {
                comboBoxProductType.Items.Add(types[i].Name);
            }
                                        
        }

        private void Check_Click(object sender, EventArgs e)
        {
            Ticket f4;
            f4 = new Ticket();
            f4.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {           
            
                    
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            listBoxCart.Items.Add(dataGridViewProdcuts.SelectedRows[0]);
        }
    }
}
