using System;
using System.Windows.Forms;
using ShopWorkWithDB;
using System.Collections.Generic;
using System.Linq;


namespace WindowsFormsApplication19
{
    public partial class Cashier : Form
    {
        ShopDbService dbService;
        User user;
        IEnumerable<Product> allProducts;        
        Product product; 

        /// <summary>
        /// Конструктор форми Cashier який ініціалізує тип продуктів та продукти
        /// </summary>
        /// <param name="dbService"></param>
        /// <param name="user"></param>

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
            if(comboBoxProductType.Items.Count > 0)
            {
                comboBoxProductType.SelectedIndex = 0;
            }       
            
                 
                                        
        }

        /// <summary>
        /// Обробник в якому створюється модель даних квиток, також видаляються з бази продані продукти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Check_Click(object sender, EventArgs e)
        {
            List<SoldProduct> soldProducts = new List<SoldProduct>();
            for(int i=0; i<listViewCart.Items.Count; i++)
            {
                string productName = listViewCart.Items[i].SubItems[0].Text;
                int productCount = Convert.ToInt32(listViewCart.Items[i].SubItems[1].Text);
                int productPrice = Convert.ToInt32(listViewCart.Items[i].SubItems[2].Text);
                soldProducts.Add(new SoldProduct() { Product = productName, count = productCount, price = productPrice });
            }

            TicketModel model = new TicketModel() { Cashier = textBoxCashierName.Text, Products = soldProducts, price = Convert.ToInt32(textBoxTotalPrice.Text) };


            for(int i=0; i<model.Products.Count; i++)
            {
                string pName = model.Products[i].Product;
                Product p = dbService.DB.Products.Where(x => x.Name == pName).SingleOrDefault();
                if (p != null) p.Count = p.Count - model.Products[i].count;
            }

            dbService.DB.SaveChanges();
            listViewCart.Clear();
            LoadAllProducts();
            textBoxTotalPrice.Text = "";


            Ticket ticketForm = new Ticket(model);
            ticketForm.ShowDialog();
        }       

        /// <summary>
        /// Обробник на кнопку яка добавляє товар з складу до корзини
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridViewProdcuts.SelectedRows[0].Cells["Id"].Value;
            
            product = allProducts.Where(x => x.Id == id).SingleOrDefault();
            if (!listViewCart.Items.Cast<ListViewItem>().Any(item => item.Text == product.Name))
            {
                listViewCart.Items.Add(new ListViewItem(new string[] { product.Name, "1", Convert.ToString(product.Price) }));
                listViewCart.Items[listViewCart.Items.Count - 1].Selected = true;
                fillNumeric();
                CountFullPrice();
            }
        }

        private void comboBoxProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllProducts();            
        }

        

        private void listViewCart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                product = allProducts.Where(x => x.Name == listViewCart.SelectedItems[0].Text).SingleOrDefault();
                numericUpDownCart.ReadOnly = false;
                fillNumeric();
            }
            else
                numericUpDownCart.ReadOnly = true;
            
        }


       /// <summary>
       /// Метод який ініціалізує numericUpDown
       /// </summary>
        private void fillNumeric()
        {
            if(product != null)
            numericUpDownCart.Maximum = product.Count;            
            if(listViewCart.SelectedItems.Count > 0)
            numericUpDownCart.Value = Convert.ToInt32(listViewCart.SelectedItems[0].SubItems[1].Text);            
        }

        private void numericUpDownCart_ValueChanged(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                ListViewItem i =listViewCart.Items.Cast<ListViewItem>().Where(x => x.Text == product.Name).SingleOrDefault();
                i.SubItems[1].Text = numericUpDownCart.Value.ToString();
                i.SubItems[2].Text = Convert.ToString(numericUpDownCart.Value * Convert.ToDecimal(product.Price));
                CountFullPrice();
            }
        }

        /// <summary>
        /// Обробник який видаяє продукт з корзини
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonDeleteFromCart_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                listViewCart.Items.RemoveAt(listViewCart.SelectedItems[0].Index);
                product = null;
                CountFullPrice();
            }
        }

        /// <summary>
        /// Метод який рахує загальну ціну всіх товарі  в корзині
        /// </summary>
        private void CountFullPrice()
        {
            int price = 0;
            ListViewItem[] items = listViewCart.Items.Cast<ListViewItem>().ToArray();
            for(int i=0; i<items.Length; i++)
            {
                price += Convert.ToInt32(items[i].SubItems[2].Text);
            }
            textBoxTotalPrice.Text = price.ToString();
        }


        /// <summary>
        /// Метод який загружає продукти певного типу з бази
        /// </summary>
        private void LoadAllProducts()
        {
            allProducts = from allProducts in dbService.DB.Products
                          where allProducts.Type.Name == comboBoxProductType.Text
                          select allProducts;
            dataGridViewProdcuts.DataSource = allProducts.Select(x => new { Id = x.Id, Name = x.Name, Count = x.Count, Price = x.Price }).ToList();
        }
    }
}
