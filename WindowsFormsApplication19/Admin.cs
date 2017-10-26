using System;
using System.Drawing;
using System.Windows.Forms;
using ShopWorkWithDB;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication19
{
    /// <summary>
    /// Форма Адміна
    /// </summary>
    public partial class Admin : Form
    {
        ShopDbService dbService;

        User user;

        SqlCommandBuilder scb;
        SqlConnection con = new SqlConnection(GetConnectionString());
        SqlDataAdapter sda;
        DataTable dt;

        /// <summary>
        /// Конструктор Адміна 
        /// </summary>
        /// <param name="dbService"></param>
        /// <param name="user"></param>
        public Admin(ShopDbService dbService, User user)
        {
            InitializeComponent();
            this.dbService = dbService;
            this.user = user;

        }
        /// <summary>
        /// Заргузка форми Адмін і його імя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Admin_Load(object sender, EventArgs e)
        {
            txtBoxAdminName.Text = user.Name;
        }
        private static string GetConnectionString()
        {
            //       Data Source=Підключення до сервера ; Initial Catalog = Назва БазиДанних ; Integrated Security = перевірка автентичності ;  логін ;  пароль ;
            return @"Data Source=ShopDataBase.mssql.somee.com; Initial Catalog=ShopDataBase; Integrated Security=False; User ID=kosmi4_SQLLogin_2; Password=hb29w57hmo";
        }
        /// <summary>
        /// Кнопка Товари перехід на форму Товарів для роботи з ними
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProducts_Click(object sender, EventArgs e)
        {
            AdminProducts adminProducts = new AdminProducts();
            adminProducts.ShowDialog();
        }
        /// <summary>
        /// Кнопка показати  Знижки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter("SELECT * FROM Discount", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewDiscount.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Кнопка редагувати знижки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateDiscount_Click(object sender, EventArgs e)
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
            MessageBox.Show("Updated", "Form Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Кнопка показати усіх працівників в таблицю DataGridView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintUser_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter("SELECT * FROM [User]", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewUser.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Кнопка Редагування Касирів можна прямо із таблиці і нажати кнопку EditCashire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateUser_Click(object sender, EventArgs e)
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
            MessageBox.Show("Updated", "Form Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        /// <summary>
        /// Кнопка Звіти тут будуть наші звіти 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReports_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Кнопка вихід з форми Адміна на форму Логовання
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
