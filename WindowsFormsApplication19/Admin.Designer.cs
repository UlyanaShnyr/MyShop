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
            this.labDiscount = new System.Windows.Forms.Label();
            this.txtBoxAdminName = new System.Windows.Forms.TextBox();
            this.labAdmin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            this.groupBoxDiscount = new System.Windows.Forms.GroupBox();
            this.btnUpdateDiscount = new System.Windows.Forms.Button();
            this.btnPrintDiscount = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnPrintUser = new System.Windows.Forms.Button();
            this.labUser = new System.Windows.Forms.Label();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).BeginInit();
            this.groupBoxDiscount.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.SuspendLayout();
            // 
            // labDiscount
            // 
            this.labDiscount.AutoSize = true;
            this.labDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDiscount.ForeColor = System.Drawing.Color.White;
            this.labDiscount.Location = new System.Drawing.Point(133, 91);
            this.labDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(225, 20);
            this.labDiscount.TabIndex = 32;
            this.labDiscount.Text = "Форма Записів Знижки";
            // 
            // txtBoxAdminName
            // 
            this.txtBoxAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxAdminName.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxAdminName.Location = new System.Drawing.Point(18, 38);
            this.txtBoxAdminName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAdminName.Name = "txtBoxAdminName";
            this.txtBoxAdminName.ReadOnly = true;
            this.txtBoxAdminName.Size = new System.Drawing.Size(198, 27);
            this.txtBoxAdminName.TabIndex = 31;
            this.txtBoxAdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labAdmin
            // 
            this.labAdmin.AutoSize = true;
            this.labAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labAdmin.ForeColor = System.Drawing.Color.White;
            this.labAdmin.Location = new System.Drawing.Point(13, 9);
            this.labAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labAdmin.Name = "labAdmin";
            this.labAdmin.Size = new System.Drawing.Size(156, 25);
            this.labAdmin.TabIndex = 22;
            this.labAdmin.Text = "Адміністратор:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(540, 24);
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
            this.label1.Location = new System.Drawing.Point(275, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 52);
            this.label1.TabIndex = 20;
            this.label1.Text = "\"SportsEat\"";
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.White;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProducts.ForeColor = System.Drawing.Color.Red;
            this.btnProducts.Location = new System.Drawing.Point(849, 9);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(185, 70);
            this.btnProducts.TabIndex = 36;
            this.btnProducts.Text = "Форма Товари";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // dataGridViewDiscount
            // 
            this.dataGridViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscount.Location = new System.Drawing.Point(18, 114);
            this.dataGridViewDiscount.Name = "dataGridViewDiscount";
            this.dataGridViewDiscount.RowTemplate.Height = 24;
            this.dataGridViewDiscount.Size = new System.Drawing.Size(453, 269);
            this.dataGridViewDiscount.TabIndex = 37;
            // 
            // groupBoxDiscount
            // 
            this.groupBoxDiscount.BackColor = System.Drawing.Color.White;
            this.groupBoxDiscount.Controls.Add(this.btnUpdateDiscount);
            this.groupBoxDiscount.Controls.Add(this.btnPrintDiscount);
            this.groupBoxDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxDiscount.ForeColor = System.Drawing.Color.Red;
            this.groupBoxDiscount.Location = new System.Drawing.Point(521, 105);
            this.groupBoxDiscount.Name = "groupBoxDiscount";
            this.groupBoxDiscount.Size = new System.Drawing.Size(240, 278);
            this.groupBoxDiscount.TabIndex = 38;
            this.groupBoxDiscount.TabStop = false;
            this.groupBoxDiscount.Text = "Знижки";
            // 
            // btnUpdateDiscount
            // 
            this.btnUpdateDiscount.BackColor = System.Drawing.Color.Red;
            this.btnUpdateDiscount.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDiscount.Location = new System.Drawing.Point(35, 156);
            this.btnUpdateDiscount.Name = "btnUpdateDiscount";
            this.btnUpdateDiscount.Size = new System.Drawing.Size(175, 70);
            this.btnUpdateDiscount.TabIndex = 1;
            this.btnUpdateDiscount.Text = "Оновлення Записи Знижки";
            this.btnUpdateDiscount.UseVisualStyleBackColor = false;
            this.btnUpdateDiscount.Click += new System.EventHandler(this.btnUpdateDiscount_Click);
            // 
            // btnPrintDiscount
            // 
            this.btnPrintDiscount.BackColor = System.Drawing.Color.Red;
            this.btnPrintDiscount.ForeColor = System.Drawing.Color.White;
            this.btnPrintDiscount.Location = new System.Drawing.Point(35, 41);
            this.btnPrintDiscount.Name = "btnPrintDiscount";
            this.btnPrintDiscount.Size = new System.Drawing.Size(175, 70);
            this.btnPrintDiscount.TabIndex = 0;
            this.btnPrintDiscount.Text = "Показати Запити Знижки";
            this.btnPrintDiscount.UseVisualStyleBackColor = false;
            this.btnPrintDiscount.Click += new System.EventHandler(this.btnPrintDiscount_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.Color.White;
            this.groupBoxUser.Controls.Add(this.btnUpdateUser);
            this.groupBoxUser.Controls.Add(this.btnPrintUser);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUser.ForeColor = System.Drawing.Color.Red;
            this.groupBoxUser.Location = new System.Drawing.Point(793, 105);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(240, 278);
            this.groupBoxUser.TabIndex = 38;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Працівники";
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Red;
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(35, 156);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(175, 79);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Оновлення Записів Працівників";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnPrintUser
            // 
            this.btnPrintUser.BackColor = System.Drawing.Color.Red;
            this.btnPrintUser.ForeColor = System.Drawing.Color.White;
            this.btnPrintUser.Location = new System.Drawing.Point(35, 41);
            this.btnPrintUser.Name = "btnPrintUser";
            this.btnPrintUser.Size = new System.Drawing.Size(175, 79);
            this.btnPrintUser.TabIndex = 0;
            this.btnPrintUser.Text = "Показати Записів Працівників";
            this.btnPrintUser.UseVisualStyleBackColor = false;
            this.btnPrintUser.Click += new System.EventHandler(this.btnPrintUser_Click);
            // 
            // labUser
            // 
            this.labUser.AutoSize = true;
            this.labUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUser.ForeColor = System.Drawing.Color.White;
            this.labUser.Location = new System.Drawing.Point(335, 406);
            this.labUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUser.Name = "labUser";
            this.labUser.Size = new System.Drawing.Size(267, 20);
            this.labUser.TabIndex = 32;
            this.labUser.Text = "Форма Записів Працівників";
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(13, 434);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(1021, 298);
            this.dataGridViewUser.TabIndex = 39;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Red;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(235, 739);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(201, 49);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Звіти";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(632, 739);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(201, 49);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1045, 798);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.groupBoxDiscount);
            this.Controls.Add(this.dataGridViewDiscount);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.labUser);
            this.Controls.Add(this.labDiscount);
            this.Controls.Add(this.txtBoxAdminName);
            this.Controls.Add(this.labAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).EndInit();
            this.groupBoxDiscount.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.TextBox txtBoxAdminName;
        private System.Windows.Forms.Label labAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.GroupBox groupBoxDiscount;
        private System.Windows.Forms.Button btnUpdateDiscount;
        private System.Windows.Forms.Button btnPrintDiscount;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnPrintUser;
        private System.Windows.Forms.Label labUser;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnExit;
    }
}