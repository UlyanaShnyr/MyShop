﻿using System;
using System.Windows.Forms;
using ShopWorkWithDB;


namespace WindowsFormsApplication19
{
    public partial class Cashier : Form
    {
        ShopDbService dbService;
        
        public Cashier(ShopDbService dbService)
        {
            InitializeComponent();
            this.dbService = dbService;
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

        private void Cashier_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Actions_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CashierName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}