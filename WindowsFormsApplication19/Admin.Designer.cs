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
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewCashier = new System.Windows.Forms.DataGridView();
            this.btnPrintCashier = new System.Windows.Forms.Button();
            this.btnEditCashier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreateDataBase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 481);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Форма Записів Товара";
            // 
            // AdminName
            // 
            this.AdminName.ForeColor = System.Drawing.Color.Gray;
            this.AdminName.Location = new System.Drawing.Point(181, 75);
            this.AdminName.Margin = new System.Windows.Forms.Padding(4);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(277, 22);
            this.AdminName.TabIndex = 31;
            this.AdminName.Text = "Ф.І.";
            this.AdminName.TextChanged += new System.EventHandler(this.AdminName_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(458, 870);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(272, 49);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Адміністратор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(679, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "\"SportsEat\"";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Red;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(1064, 643);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(161, 62);
            this.btnEditProduct.TabIndex = 33;
            this.btnEditProduct.Text = "Оновлення Записів Товара";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.BackColor = System.Drawing.Color.Red;
            this.btnPrintProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrintProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrintProduct.Location = new System.Drawing.Point(1064, 573);
            this.btnPrintProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(161, 62);
            this.btnPrintProduct.TabIndex = 34;
            this.btnPrintProduct.Text = "Показати Записи Товарів";
            this.btnPrintProduct.UseVisualStyleBackColor = false;
            this.btnPrintProduct.Click += new System.EventHandler(this.btnPrintProduct_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(22, 504);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1035, 298);
            this.dataGridViewProducts.TabIndex = 37;
            // 
            // dataGridViewCashier
            // 
            this.dataGridViewCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashier.Location = new System.Drawing.Point(22, 143);
            this.dataGridViewCashier.Name = "dataGridViewCashier";
            this.dataGridViewCashier.RowTemplate.Height = 24;
            this.dataGridViewCashier.Size = new System.Drawing.Size(1035, 298);
            this.dataGridViewCashier.TabIndex = 38;
            // 
            // btnPrintCashier
            // 
            this.btnPrintCashier.BackColor = System.Drawing.Color.Red;
            this.btnPrintCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrintCashier.ForeColor = System.Drawing.Color.White;
            this.btnPrintCashier.Location = new System.Drawing.Point(1063, 211);
            this.btnPrintCashier.Name = "btnPrintCashier";
            this.btnPrintCashier.Size = new System.Drawing.Size(160, 62);
            this.btnPrintCashier.TabIndex = 39;
            this.btnPrintCashier.Text = "Показати Записи Касирів";
            this.btnPrintCashier.UseVisualStyleBackColor = false;
            this.btnPrintCashier.Click += new System.EventHandler(this.btnPrintCashier_Click);
            // 
            // btnEditCashier
            // 
            this.btnEditCashier.BackColor = System.Drawing.Color.Red;
            this.btnEditCashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditCashier.ForeColor = System.Drawing.Color.White;
            this.btnEditCashier.Location = new System.Drawing.Point(1063, 279);
            this.btnEditCashier.Name = "btnEditCashier";
            this.btnEditCashier.Size = new System.Drawing.Size(160, 62);
            this.btnEditCashier.TabIndex = 41;
            this.btnEditCashier.Text = "Оновлення Записів Касирів";
            this.btnEditCashier.UseVisualStyleBackColor = false;
            this.btnEditCashier.Click += new System.EventHandler(this.btnEditCashier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 32;
            this.label5.Text = "Форма Записів Касирів";
            // 
            // btnCreateDataBase
            // 
            this.btnCreateDataBase.BackColor = System.Drawing.Color.Red;
            this.btnCreateDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreateDataBase.ForeColor = System.Drawing.Color.White;
            this.btnCreateDataBase.Location = new System.Drawing.Point(1064, 9);
            this.btnCreateDataBase.Name = "btnCreateDataBase";
            this.btnCreateDataBase.Size = new System.Drawing.Size(161, 62);
            this.btnCreateDataBase.TabIndex = 42;
            this.btnCreateDataBase.Text = "Створення Бази";
            this.btnCreateDataBase.UseVisualStyleBackColor = false;
            this.btnCreateDataBase.Click += new System.EventHandler(this.btnCreateDataBase_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1236, 932);
            this.Controls.Add(this.btnCreateDataBase);
            this.Controls.Add(this.btnEditCashier);
            this.Controls.Add(this.btnPrintCashier);
            this.Controls.Add(this.dataGridViewCashier);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.btnPrintProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdminName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewCashier;
        private System.Windows.Forms.Button btnPrintCashier;
        private System.Windows.Forms.Button btnEditCashier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateDataBase;
    }
}