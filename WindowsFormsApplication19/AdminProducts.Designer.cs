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
            this.labDiscount = new System.Windows.Forms.Label();
            this.dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            this.groupBoxDiscount = new System.Windows.Forms.GroupBox();
            this.btnUpdateDiscount = new System.Windows.Forms.Button();
            this.btnPrintDiscount = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).BeginInit();
            this.groupBoxDiscount.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(414, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = "\"SportsEat\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(410, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDiscount.ForeColor = System.Drawing.Color.White;
            this.labDiscount.Location = new System.Drawing.Point(95, 76);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(181, 17);
            this.labDiscount.TabIndex = 33;
            this.labDiscount.Text = "Форма Записів Знижки";
            // 
            // dataGridViewDiscount
            // 
            this.dataGridViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscount.Location = new System.Drawing.Point(14, 95);
            this.dataGridViewDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDiscount.Name = "dataGridViewDiscount";
            this.dataGridViewDiscount.RowTemplate.Height = 24;
            this.dataGridViewDiscount.Size = new System.Drawing.Size(340, 219);
            this.dataGridViewDiscount.TabIndex = 38;
            // 
            // groupBoxDiscount
            // 
            this.groupBoxDiscount.BackColor = System.Drawing.Color.White;
            this.groupBoxDiscount.Controls.Add(this.btnUpdateDiscount);
            this.groupBoxDiscount.Controls.Add(this.btnPrintDiscount);
            this.groupBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDiscount.ForeColor = System.Drawing.Color.Red;
            this.groupBoxDiscount.Location = new System.Drawing.Point(358, 88);
            this.groupBoxDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDiscount.Name = "groupBoxDiscount";
            this.groupBoxDiscount.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDiscount.Size = new System.Drawing.Size(180, 226);
            this.groupBoxDiscount.TabIndex = 39;
            this.groupBoxDiscount.TabStop = false;
            this.groupBoxDiscount.Text = "Знижки";
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.BackColor = System.Drawing.Color.Red;
            this.btnUpdateDiscount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDiscount.Location = new System.Drawing.Point(26, 113);
            this.btnUpdateDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(131, 71);
            this.btnUpdateDiscount.TabIndex = 1;
            this.btnUpdateDiscount.Text = "Оновлення Записи Знижки";
            this.btnUpdateDiscount.UseVisualStyleBackColor = false;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // btnPrintDiscount
            // 
            this.btnPrintDiscount.BackColor = System.Drawing.Color.Red;
            this.btnPrintDiscount.ForeColor = System.Drawing.Color.White;
            this.btnPrintDiscount.Location = new System.Drawing.Point(26, 33);
            this.btnPrintDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintDiscount.Name = "btnPrintDiscount";
            this.btnPrintDiscount.Size = new System.Drawing.Size(131, 71);
            this.btnPrintDiscount.TabIndex = 0;
            this.btnPrintDiscount.Text = "Показати Запити Знижки";
            this.btnPrintDiscount.UseVisualStyleBackColor = false;
            this.btnPrintDiscount.Click += new System.EventHandler(this.btnPrintDiscount_Click);
            // 
            // dataGridViewTypeProduct
            // 
            this.dataGridViewTypeProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTypeProduct.Location = new System.Drawing.Point(575, 95);
            this.dataGridViewTypeProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTypeProduct.Name = "dataGridViewTypeProduct";
            this.dataGridViewTypeProduct.RowTemplate.Height = 24;
            this.dataGridViewTypeProduct.Size = new System.Drawing.Size(241, 219);
            this.dataGridViewTypeProduct.TabIndex = 40;
            // 
            // labTypeProduct
            // 
            this.labTypeProduct.AutoSize = true;
            this.labTypeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTypeProduct.ForeColor = System.Drawing.Color.White;
            this.labTypeProduct.Location = new System.Drawing.Point(586, 76);
            this.labTypeProduct.Name = "labTypeProduct";
            this.labTypeProduct.Size = new System.Drawing.Size(229, 17);
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
            this.groupBoxTypeProduct.Location = new System.Drawing.Point(820, 88);
            this.groupBoxTypeProduct.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxTypeProduct.Name = "groupBoxTypeProduct";
            this.groupBoxTypeProduct.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxTypeProduct.Size = new System.Drawing.Size(180, 226);
            this.groupBoxTypeProduct.TabIndex = 39;
            this.groupBoxTypeProduct.TabStop = false;
            this.groupBoxTypeProduct.Text = "Тип Продукту";
            // 
            // btnEditTypeProduct
            // 
            this.btnEditTypeProduct.BackColor = System.Drawing.Color.Red;
            this.btnEditTypeProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditTypeProduct.Location = new System.Drawing.Point(26, 113);
            this.btnEditTypeProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditTypeProduct.Name = "btnEditTypeProduct";
            this.btnEditTypeProduct.Size = new System.Drawing.Size(131, 71);
            this.btnEditTypeProduct.TabIndex = 1;
            this.btnEditTypeProduct.Text = "Оновлення Записи Тип Продукту";
            this.btnEditTypeProduct.UseVisualStyleBackColor = false;
            this.btnEditTypeProduct.Click += new System.EventHandler(this.btnEditTypeProduct_Click);
            // 
            // btnPrintTypeProduct
            // 
            this.btnPrintTypeProduct.BackColor = System.Drawing.Color.Red;
            this.btnPrintTypeProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrintTypeProduct.Location = new System.Drawing.Point(26, 33);
            this.btnPrintTypeProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintTypeProduct.Name = "btnPrintTypeProduct";
            this.btnPrintTypeProduct.Size = new System.Drawing.Size(131, 71);
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
            this.laиProduct.Location = new System.Drawing.Point(324, 335);
            this.laиProduct.Name = "laиProduct";
            this.laиProduct.Size = new System.Drawing.Size(196, 17);
            this.laиProduct.TabIndex = 42;
            this.laиProduct.Text = "Форма Записів Продукту";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(14, 353);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(802, 217);
            this.dataGridViewProduct.TabIndex = 43;
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.BackColor = System.Drawing.Color.White;
            this.groupBoxProduct.Controls.Add(this.btnEditProduct);
            this.groupBoxProduct.Controls.Add(this.btnPrintProduct);
            this.groupBoxProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxProduct.ForeColor = System.Drawing.Color.Red;
            this.groupBoxProduct.Location = new System.Drawing.Point(820, 344);
            this.groupBoxProduct.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxProduct.Size = new System.Drawing.Size(180, 226);
            this.groupBoxProduct.TabIndex = 44;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Продукти";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Red;
            this.btnEditProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditProduct.Location = new System.Drawing.Point(26, 121);
            this.btnEditProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(131, 71);
            this.btnEditProduct.TabIndex = 1;
            this.btnEditProduct.Text = "Оновлення Записи Продукту";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnPrintProduct
            // 
            this.btnPrintProduct.BackColor = System.Drawing.Color.Red;
            this.btnPrintProduct.ForeColor = System.Drawing.Color.White;
            this.btnPrintProduct.Location = new System.Drawing.Point(26, 33);
            this.btnPrintProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrintProduct.Name = "btnPrintProduct";
            this.btnPrintProduct.Size = new System.Drawing.Size(131, 71);
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
            this.btnExit.Location = new System.Drawing.Point(391, 580);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(237, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AdminProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1011, 631);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.laиProduct);
            this.Controls.Add(this.labTypeProduct);
            this.Controls.Add(this.dataGridViewTypeProduct);
            this.Controls.Add(this.groupBoxTypeProduct);
            this.Controls.Add(this.groupBoxDiscount);
            this.Controls.Add(this.dataGridViewDiscount);
            this.Controls.Add(this.labDiscount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminProducts";
            this.Text = "AdminProducts";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).EndInit();
            this.groupBoxDiscount.ResumeLayout(false);
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
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.GroupBox groupBoxDiscount;
        private System.Windows.Forms.Button btnUpdateDiscount;
        private System.Windows.Forms.Button btnPrintDiscount;
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