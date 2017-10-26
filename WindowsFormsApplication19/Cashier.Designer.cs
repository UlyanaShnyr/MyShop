namespace WindowsFormsApplication19
{
    partial class Cashier
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxCashierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewProdcuts = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.ColumnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownCart = new System.Windows.Forms.NumericUpDown();
            this.buttonDeleteFromCart = new System.Windows.Forms.Button();
            this.comboBoxProductType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listViewActions = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdcuts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCart)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"SportsEat\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Касир: ";
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.BackColor = System.Drawing.Color.Red;
            this.buttonAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToCart.ForeColor = System.Drawing.Color.White;
            this.buttonAddToCart.Location = new System.Drawing.Point(3, 19);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(137, 29);
            this.buttonAddToCart.TabIndex = 12;
            this.buttonAddToCart.Text = "Додати в корзину";
            this.buttonAddToCart.UseVisualStyleBackColor = false;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTotalPrice.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(879, 439);
            this.textBoxTotalPrice.Multiline = true;
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(180, 31);
            this.textBoxTotalPrice.TabIndex = 13;
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Red;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(139, 441);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(177, 34);
            this.buttonCheck.TabIndex = 14;
            this.buttonCheck.Text = "Оформити чек";
            this.buttonCheck.UseVisualStyleBackColor = false;
            this.buttonCheck.Click += new System.EventHandler(this.Check_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(351, 441);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(177, 34);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            // 
            // textBoxCashierName
            // 
            this.textBoxCashierName.Enabled = false;
            this.textBoxCashierName.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCashierName.Location = new System.Drawing.Point(69, 86);
            this.textBoxCashierName.Name = "textBoxCashierName";
            this.textBoxCashierName.Size = new System.Drawing.Size(209, 20);
            this.textBoxCashierName.TabIndex = 16;
            this.textBoxCashierName.Text = "Ф.І.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(348, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Товари";
            // 
            // dataGridViewProdcuts
            // 
            this.dataGridViewProdcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdcuts.Location = new System.Drawing.Point(139, 162);
            this.dataGridViewProdcuts.Name = "dataGridViewProdcuts";
            this.dataGridViewProdcuts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewProdcuts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdcuts.Size = new System.Drawing.Size(465, 264);
            this.dataGridViewProdcuts.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(733, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Корзина";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewCart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDownCart);
            this.panel1.Controls.Add(this.buttonDeleteFromCart);
            this.panel1.Controls.Add(this.buttonAddToCart);
            this.panel1.Location = new System.Drawing.Point(610, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 264);
            this.panel1.TabIndex = 23;
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnCount,
            this.ColumnPrice});
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.Location = new System.Drawing.Point(146, 19);
            this.listViewCart.MultiSelect = false;
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(303, 229);
            this.listViewCart.TabIndex = 25;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            this.listViewCart.SelectedIndexChanged += new System.EventHandler(this.listViewCart_SelectedIndexChanged);
            // 
            // ColumnName
            // 
            this.ColumnName.Text = "Name";
            this.ColumnName.Width = 100;
            // 
            // ColumnCount
            // 
            this.ColumnCount.Text = "Count";
            this.ColumnCount.Width = 100;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.Text = "Price";
            this.ColumnPrice.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Кільскість";
            // 
            // numericUpDownCart
            // 
            this.numericUpDownCart.Location = new System.Drawing.Point(88, 105);
            this.numericUpDownCart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCart.Name = "numericUpDownCart";
            this.numericUpDownCart.Size = new System.Drawing.Size(52, 20);
            this.numericUpDownCart.TabIndex = 23;
            this.numericUpDownCart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCart.ValueChanged += new System.EventHandler(this.numericUpDownCart_ValueChanged);
            // 
            // buttonDeleteFromCart
            // 
            this.buttonDeleteFromCart.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteFromCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteFromCart.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteFromCart.Location = new System.Drawing.Point(3, 54);
            this.buttonDeleteFromCart.Name = "buttonDeleteFromCart";
            this.buttonDeleteFromCart.Size = new System.Drawing.Size(137, 29);
            this.buttonDeleteFromCart.TabIndex = 22;
            this.buttonDeleteFromCart.Text = "Видалити";
            this.buttonDeleteFromCart.UseVisualStyleBackColor = false;
            this.buttonDeleteFromCart.Click += new System.EventHandler(this.buttonDeleteFromCart_Click);
            // 
            // comboBoxProductType
            // 
            this.comboBoxProductType.FormattingEnabled = true;
            this.comboBoxProductType.Location = new System.Drawing.Point(12, 162);
            this.comboBoxProductType.Name = "comboBoxProductType";
            this.comboBoxProductType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProductType.TabIndex = 24;
            this.comboBoxProductType.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Тип товару";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(684, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "Загальна ціна";
            // 
            // listViewActions
            // 
            this.listViewActions.Location = new System.Drawing.Point(88, 18);
            this.listViewActions.Name = "listViewActions";
            this.listViewActions.Size = new System.Drawing.Size(620, 97);
            this.listViewActions.TabIndex = 27;
            this.listViewActions.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Акції";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.listViewActions);
            this.panel2.Location = new System.Drawing.Point(351, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 128);
            this.panel2.TabIndex = 29;
            this.panel2.Visible = false;
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1092, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxProductType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewProdcuts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCashierName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdcuts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCart)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxCashierName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewProdcuts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownCart;
        private System.Windows.Forms.Button buttonDeleteFromCart;
        private System.Windows.Forms.ComboBox comboBoxProductType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader ColumnName;
        private System.Windows.Forms.ColumnHeader ColumnCount;
        private System.Windows.Forms.ColumnHeader ColumnPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView listViewActions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
    }
}