namespace WindowsFormsApplication19
{
    partial class AdminProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labSale = new System.Windows.Forms.Label();
            this.dataGridViewSale = new System.Windows.Forms.DataGridView();
            this.groupBoxSale = new System.Windows.Forms.GroupBox();
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.btnPrintSale = new System.Windows.Forms.Button();
            this.dataGridViewTypeProduct = new System.Windows.Forms.DataGridView();
            this.labTypeProduct = new System.Windows.Forms.Label();
            this.groupBoxTypeProduct = new System.Windows.Forms.GroupBox();
            this.btnEditTypeProduct = new System.Windows.Forms.Button();
            this.btnPrintTypeProduct = new System.Windows.Forms.Button();
            this.laиProduct = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnPrintProduct = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).BeginInit();
            this.groupBoxSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeProduct)).BeginInit();
            this.groupBoxTypeProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.groupBoxProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(552, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 52);
            this.label1.TabIndex = 21;
            this.label1.Text = "\"SportsEat\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(546, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // labSale
            // 
            this.labSale.AutoSize = true;
            this.labSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labSale.ForeColor = System.Drawing.Color.White;
            this.labSale.Location = new System.Drawing.Point(127, 94);
            this.labSale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSale.Name = "labSale";
            this.labSale.Size = new System.Drawing.Size(229, 20);
            this.labSale.TabIndex = 33;
            this.labSale.Text = "Форма Записів Продаж";
            // 
            // dataGridViewSale
            // 
            this.dataGridViewSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSale.Location = new System.Drawing.Point(18, 117);
            this.dataGridViewSale.Name = "dataGridViewSale";
            this.dataGridViewSale.RowTemplate.Height = 24;
            this.dataGridViewSale.Size = new System.Drawing.Size(453, 269);
            this.dataGridViewSale.TabIndex = 38;
            // 
            // groupBoxSale
            // 
            this.groupBoxSale.BackColor = System.Drawing.Color.White;
            this.groupBoxSale.Controls.Add(this.btnUpdateSale);
            this.groupBoxSale.Controls.Add(this.btnPrintSale);
            this.groupBoxSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxSale.ForeColor = System.Drawing.Color.Red;
            this.groupBoxSale.Location = new System.Drawing.Point(477, 108);
            this.groupBoxSale.Name = "groupBoxSale";
            this.groupBoxSale.Size = new System.Drawing.Size(240, 278);
            this.groupBoxSale.TabIndex = 39;
            this.groupBoxSale.TabStop = false;
            this.groupBoxSale.Text = "Продажі";
            // 
            // btnUpdateSale
            // 
            this.btnUpdateSale.BackColor = System.Drawing.Color.Red;
            this.btnUpdateSale.ForeColor = System.Drawing.Color.White;
            this.btnUpdateSale.Location = new System.Drawing.Point(35, 139);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Size = new System.Drawing.Size(175, 87);
            this.btnUpdateSale.TabIndex = 1;
            this.btnUpdateSale.Text = "Оновлення Записи Продаж";
            this.btnUpdateSale.UseVisualStyleBackColor = false;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // btnPrintSale
            // 
            this.btnPrintSale.BackColor = System.Drawing.Color.Red;
            this.btnPrintSale.ForeColor = System.Drawing.Color.White;
            this.btnPrintSale.Location = new System.Drawing.Point(35, 41);
            this.btnPrintSale.Name = "btnPrintSale";
            this.btnPrintSale.Size = new System.Drawing.Size(175, 87);
            this.btnPrintSale.TabIndex = 0;
            this.btnPrintSale.Text = "Показати Запити Продаж";
            this.btnPrintSale.UseVisualStyleBackColor = false;
            this.btnPrintSale.Click += new System.EventHandler(this.btnPrintSale_Click);
            // 
            // dataGridViewTypeProduct
            // 
            this.dataGridViewTypeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeProduct.Location = new System.Drawing.Point(767, 117);
            this.dataGridViewTypeProduct.Name = "dataGridViewTypeProduct";
            this.dataGridViewTypeProduct.RowTemplate.Height = 24;
            this.dataGridViewTypeProduct.Size = new System.Drawing.Size(321, 269);
            this.dataGridViewTypeProduct.TabIndex = 40;
            // 
            // labTypeProduct
            // 
            this.labTypeProduct.AutoSize = true;
            this.labTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTypeProduct.ForeColor = System.Drawing.Color.White;
            this.labTypeProduct.Location = new System.Drawing.Point(782, 94);
            this.labTypeProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTypeProduct.Name = "labTypeProduct";
            this.labTypeProduct.Size = new System.Drawing.Size(283, 20);
            this.labTypeProduct.TabIndex = 41;
            this.labTypeProduct.Text = "Форма Записів Тип Продукту";
            // 
            // groupBoxTypeProduct
            // 
            this.groupBoxTypeProduct.BackColor = System.Drawing.Color.White;
            this.groupBoxTypeProduct.Controls.Add(this.btnEditTypeProduct);
            this.groupBoxTypeProduct.Controls.Add(this.btnPrintTypeProduct);
            this.groupBoxTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTypeProduct.ForeColor = System.Drawing.Color.Red;
            this.groupBoxTypeProduct.Location = new System.Drawing.Point(1094, 108);
            this.groupBoxTypeProduct.Name = "groupBoxTypeProduct";
            this.groupBoxTypeProduct.Size = new System.Drawing.Size(240, 278);
            this.groupBoxTypeProduct.TabIndex = 39;
            this.groupBoxTypeProduct.TabStop = false;
            this.groupBoxTypeProduct.Text = "Тип Продукту";
            // 
            // btnEditTypeProduct
            // 
            this.btnEditTypeProduct.BackColor = System.Drawing.Color.Red;
            this.btnEditTypeProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditTypeProduct.Location = new System.Drawing.Point(35, 139);
            this.btnEditTypeProduct.Name = "btnEditTypeProduct";
            this.btnEditTypeProduct.Size = new System.Drawing.Size(175, 87);
            this.btnEditTypeProduct.TabIndex = 1;
            this.btnEditTypeProduct.Text = "Оновлення Записи Тип Продукту";
            this.btnEditTypeProduct.UseVisualStyleBackColor = false;
            this.btnEditTypeProduct.Click += new System.EventHandler(this.btnEditTypeProduct_Click);
            // 
            // btnPrintTypeProduct
            // 
            this.btnPrintTypeProduct.BackColor = System.Drawing.Color.Red;
            this.btnPrintTypeProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrintTypeProduct.Location = new System.Drawing.Point(35, 41);
            this.btnPrintTypeProduct.Name = "btnPrintTypeProduct";
            this.btnPrintTypeProduct.Size = new System.Drawing.Size(175, 87);
            this.btnPrintTypeProduct.TabIndex = 0;
            this.btnPrintTypeProduct.Text = "Показати Запити Тип Продукту";
            this.btnPrintTypeProduct.UseVisualStyleBackColor = false;
            this.btnPrintTypeProduct.Click += new System.EventHandler(this.btnPrintTypeProduct_Click);
            // 
            // laиProduct
            // 
            this.laиProduct.AutoSize = true;
            this.laиProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laиProduct.ForeColor = System.Drawing.Color.White;
            this.laиProduct.Location = new System.Drawing.Point(432, 412);
            this.laиProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laиProduct.Name = "laиProduct";
            this.laиProduct.Size = new System.Drawing.Size(244, 20);
            this.laиProduct.TabIndex = 42;
            this.laиProduct.Text = "Форма Записів Продукту";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(18, 435);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(1070, 267);
            this.dataGridViewProduct.TabIndex = 43;
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.BackColor = System.Drawing.Color.White;
            this.groupBoxProduct.Controls.Add(this.btnEditProduct);
            this.groupBoxProduct.Controls.Add(this.btnPrintProduct);
            this.groupBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxProduct.ForeColor = System.Drawing.Color.Red;
            this.groupBoxProduct.Location = new System.Drawing.Point(1094, 424);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(240, 278);
            this.groupBoxProduct.TabIndex = 44;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Продукти";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Red;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(35, 149);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(175, 87);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "Оновлення Записи Продукту";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.BackColor = System.Drawing.Color.Red;
            this.btnPrintProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrintProduct.Location = new System.Drawing.Point(35, 41);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(175, 87);
            this.btnPrintProduct.TabIndex = 0;
            this.btnPrintProduct.Text = "Показати Запити Продукту";
            this.btnPrintProduct.UseVisualStyleBackColor = false;
            this.btnPrintProduct.Click += new System.EventHandler(this.btnPrintProduct_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(521, 714);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(316, 51);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1351, 777);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.laиProduct);
            this.Controls.Add(this.labTypeProduct);
            this.Controls.Add(this.dataGridViewTypeProduct);
            this.Controls.Add(this.groupBoxTypeProduct);
            this.Controls.Add(this.groupBoxSale);
            this.Controls.Add(this.dataGridViewSale);
            this.Controls.Add(this.labSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminProducts";
            this.Text = "AdminProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSale)).EndInit();
            this.groupBoxSale.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTypeProduct)).EndInit();
            this.groupBoxTypeProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.groupBoxProduct.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSale;
        private System.Windows.Forms.DataGridView dataGridViewSale;
        private System.Windows.Forms.GroupBox groupBoxSale;
        private System.Windows.Forms.Button btnUpdateSale;
        private System.Windows.Forms.Button btnPrintSale;
        private System.Windows.Forms.DataGridView dataGridViewTypeProduct;
        private System.Windows.Forms.Label labTypeProduct;
        private System.Windows.Forms.GroupBox groupBoxTypeProduct;
        private System.Windows.Forms.Button btnEditTypeProduct;
        private System.Windows.Forms.Button btnPrintTypeProduct;
        private System.Windows.Forms.Label laиProduct;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnPrintProduct;
        private System.Windows.Forms.Button btnExit;
    }
}