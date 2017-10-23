using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ShopWorkWithDB;                        // підключили бібліотеку

namespace WindowsFormsApplication19
{
    /// <summary>
    /// клас Адмін
    /// </summary>
    public partial class Admin : Form
    {
        SqlCommandBuilder scb;
        SqlConnection con = new SqlConnection(GetConnectionString());
        SqlDataAdapter sda;
        DataTable dt;

        /// <summary>
        /// конструктор Адміна .
        /// </summary>
        /// <param name="mainForm"></param>
        public Admin(Login mainForm)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Стрічка підключення до бази данних 
        /// </summary>
        /// <returns></returns>
        private static string GetConnectionString()
        {
            //       Data Source=Підключення до сервера ; Initial Catalog = Назва БазиДанних ; Integrated Security = перевірка автентичності ; без логіна ; без пароля ;
            return @"Data Source=Ura\SQLEXPRESS; Initial Catalog=ShopDB; Integrated Security=True;";
        }
        /// <summary>
        /// Кнопка переглянути Касирів які є в базі данних і помістити у DataGridView таблицю
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintCashier_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM [User]", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewCashier.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        /// <summary>
        /// Кнопка Редагування Касирів можна прямо із таблиці і нажати кнопку EditCashire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditCashier_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// текстбокс Адміністратор
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminName_TextChanged(object sender, EventArgs e)
        {
            AdminName.Text = "";
            AdminName.TextChanged -= AdminName_TextChanged;
            AdminName.ForeColor = Color.Black;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                sda = new SqlDataAdapter("SELECT * FROM Product", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProducts.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }

        }
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                scb = new SqlCommandBuilder(sda);
                sda.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        /// <summary>
        /// Кнопка Виходу із форми Адміна на форму Логовання 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Login m;
            m = new Login();
            con.Close();
            this.Hide();
            m.Show();
        }
        /// <summary>
        /// Кнопка створення бази данних якщо її не має.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateDataBase_Click(object sender, EventArgs e)
        {
            using (ShopDB db = new ShopDB(GetConnectionString()))
            {
                // создаем два объекта Discount
                Discount discount1 = new Discount { Description = "Description1", Percent = 5 };
                Discount discount2 = new Discount { Description = "Description2", Percent = 3 };
                // добавляем их в бд
                db.Discount.Add(discount1); db.Discount.Add(discount2);
                // создаем два объекта User
                User user1 = new User { Name = "Tom", Surname = "Tomason", Login = "SuperTom", Password = "1234", Role = 1, Phone = "244-33-11",_Discont=discount1};
                User user2 = new User { Name = "Lisa", Surname = "Lisin", Login = "HahaLiz", Password = "1122", Role = 0, Phone = "215-20-25",_Discont=discount2 };
                // добавляем их в бд
                db.Users.Add(user1);db.Users.Add(user2);
                // создаем два объекта ProductType
                ProductType productType1 = new ProductType { Name = "Product1" };
                ProductType productType2 = new ProductType { Name = "Product2" };
                // добавляем их в бд
                db.ProductTypes.Add(productType1); db.ProductTypes.Add(productType2);
                // создаем два объекта Product
                Product product1 = new Product { Name = "Product1", Price = 100, _Count = 2, _Discont = discount1, _Type = productType1 };
                Product product2 = new Product { Name = "Product12", Price = 150, _Count = 1, _Discont = discount2, _Type = productType2 };
                // добавляем их в бд
                db.Products.Add(product1); db.Products.Add(product2);
                // зберыгаэм в базі данних
                db.SaveChanges();
                MessageBox.Show("Объекты  успешно сохранены");
                btnCreateDataBase.Visible = false;
            }

        }
    }




}
