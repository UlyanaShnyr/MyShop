using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShopWorkWithDB;
using System.Data.SqlClient;

namespace WindowsFormsApplication19
{
    /// <summary>
    /// Форма AdminProducts форма працювання з таблицями товарів 
    /// </summary>
    public partial class AdminProducts : Form
    {
        
        SqlCommandBuilder scb;
        SqlConnection con = new SqlConnection(GetConnectionString());
        SqlDataAdapter sda;
        DataTable dt;
        /// <summary>
        /// конструктор
        /// </summary>
        public AdminProducts()
        {
            InitializeComponent();
        }
        /// <summary>
        /// стрічка до бази данних
        /// </summary>
        /// <returns></returns>
        private static string GetConnectionString()
        {
            //       Data Source=Підключення до сервера ; Initial Catalog = Назва БазиДанних ; Integrated Security = перевірка автентичності ;  логін ;  пароль ;
            return @"Data Source=ShopDataBase.mssql.somee.com; Initial Catalog=ShopDataBase; Integrated Security=False; User ID=kosmi4_SQLLogin_2; Password=hb29w57hmo";
        }
        /// <summary>
        /// Кнопка показати Продажі
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintSale_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter("SELECT * FROM Sale", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Кнопка Редагувати Продажі
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateSale_Click(object sender, EventArgs e)
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
        /// Кнопка Показати Тип Продукту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintTypeProduct_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter("SELECT * FROM ProductType", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewTypeProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Кнопка Редагувати Тип Продукту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditTypeProduct_Click(object sender, EventArgs e)
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
        /// Кнопка показати Продукти
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintProduct_Click(object sender, EventArgs e)
        {
            try
            {
                sda = new SqlDataAdapter("SELECT * FROM Product", con);

                dt = new DataTable();
                sda.Fill(dt);
                dataGridViewProduct.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        /// <summary>
        /// Кнопка Редагувати Продукт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            MessageBox.Show("Updated", "Form Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        /// <summary>
        /// Кнопка Вийти 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
