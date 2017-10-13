namespace WindowsFormsApplication19
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.ListProducts = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditProduct = new System.Windows.Forms.Button();
            this.AddProduct = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.CashierRegisteration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Товар:";
            // 
            // AdminName
            // 
            this.AdminName.ForeColor = System.Drawing.Color.Gray;
            this.AdminName.Location = new System.Drawing.Point(9, 135);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(209, 20);
            this.AdminName.TabIndex = 31;
            this.AdminName.Text = "Ф.І.";
            this.AdminName.TextChanged += new System.EventHandler(this.AdminName_TextChanged);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(687, 502);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 40);
            this.Exit.TabIndex = 30;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ListProducts
            // 
            this.ListProducts.FormattingEnabled = true;
            this.ListProducts.Location = new System.Drawing.Point(10, 187);
            this.ListProducts.Name = "ListProducts";
            this.ListProducts.Size = new System.Drawing.Size(671, 355);
            this.ListProducts.TabIndex = 24;
            this.ListProducts.SelectedIndexChanged += new System.EventHandler(this.ListProducts_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Адміністратор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 20;
            this.label1.Text = "\"SportsEat\"";
            // 
            // EditProduct
            // 
            this.EditProduct.BackColor = System.Drawing.Color.Red;
            this.EditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditProduct.ForeColor = System.Drawing.Color.White;
            this.EditProduct.Location = new System.Drawing.Point(687, 187);
            this.EditProduct.Name = "EditProduct";
            this.EditProduct.Size = new System.Drawing.Size(94, 41);
            this.EditProduct.TabIndex = 33;
            this.EditProduct.Text = "Редагувати";
            this.EditProduct.UseVisualStyleBackColor = false;
            this.EditProduct.Click += new System.EventHandler(this.EditProduct_Click);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Red;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProduct.ForeColor = System.Drawing.Color.White;
            this.AddProduct.Location = new System.Drawing.Point(687, 234);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(94, 60);
            this.AddProduct.TabIndex = 34;
            this.AddProduct.Text = "Додати новий товар";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Red;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(687, 456);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(94, 40);
            this.Save.TabIndex = 35;
            this.Save.Text = "Зберегти";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // CashierRegisteration
            // 
            this.CashierRegisteration.BackColor = System.Drawing.Color.Red;
            this.CashierRegisteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CashierRegisteration.ForeColor = System.Drawing.Color.White;
            this.CashierRegisteration.Location = new System.Drawing.Point(470, 34);
            this.CashierRegisteration.Name = "CashierRegisteration";
            this.CashierRegisteration.Size = new System.Drawing.Size(211, 60);
            this.CashierRegisteration.TabIndex = 36;
            this.CashierRegisteration.Text = "Реєстрація касира";
            this.CashierRegisteration.UseVisualStyleBackColor = false;
            this.CashierRegisteration.Click += new System.EventHandler(this.CashierRegisteration_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.CashierRegisteration);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.EditProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ListProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.ListBox ListProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EditProduct;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button CashierRegisteration;
    }
}