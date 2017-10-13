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
            this.Actions = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.ComboBox();
            this.ProductsList = new System.Windows.Forms.ListBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddToBasket = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.Check = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.CashierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            // Actions
            // 
            this.Actions.ForeColor = System.Drawing.Color.Gray;
            this.Actions.Location = new System.Drawing.Point(284, 17);
            this.Actions.Multiline = true;
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(488, 90);
            this.Actions.TabIndex = 4;
            this.Actions.Text = "Акції";
            this.Actions.TextChanged += new System.EventHandler(this.Actions_TextChanged);
            // 
            // Number
            // 
            this.Number.FormattingEnabled = true;
            this.Number.Location = new System.Drawing.Point(635, 162);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(137, 21);
            this.Number.TabIndex = 10;
            // 
            // ProductsList
            // 
            this.ProductsList.FormattingEnabled = true;
            this.ProductsList.Location = new System.Drawing.Point(4, 162);
            this.ProductsList.Name = "ProductsList";
            this.ProductsList.Size = new System.Drawing.Size(624, 277);
            this.ProductsList.TabIndex = 5;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(635, 215);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(137, 20);
            this.Price.TabIndex = 11;
            // 
            // AddToBasket
            // 
            this.AddToBasket.BackColor = System.Drawing.Color.Red;
            this.AddToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToBasket.ForeColor = System.Drawing.Color.White;
            this.AddToBasket.Location = new System.Drawing.Point(635, 250);
            this.AddToBasket.Name = "AddToBasket";
            this.AddToBasket.Size = new System.Drawing.Size(137, 29);
            this.AddToBasket.TabIndex = 12;
            this.AddToBasket.Text = "Додати в корзину";
            this.AddToBasket.UseVisualStyleBackColor = false;
            // 
            // TotalPrice
            // 
            this.TotalPrice.ForeColor = System.Drawing.Color.Gray;
            this.TotalPrice.Location = new System.Drawing.Point(498, 445);
            this.TotalPrice.Multiline = true;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(274, 59);
            this.TotalPrice.TabIndex = 13;
            this.TotalPrice.Text = "Загальна вартість";
            // 
            // Check
            // 
            this.Check.BackColor = System.Drawing.Color.Red;
            this.Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Check.ForeColor = System.Drawing.Color.White;
            this.Check.Location = new System.Drawing.Point(4, 470);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(177, 34);
            this.Check.TabIndex = 14;
            this.Check.Text = "Оформити чек";
            this.Check.UseVisualStyleBackColor = false;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Red;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(205, 470);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(177, 34);
            this.Exit.TabIndex = 15;
            this.Exit.Text = "Вихід";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CashierName
            // 
            this.CashierName.ForeColor = System.Drawing.Color.Gray;
            this.CashierName.Location = new System.Drawing.Point(69, 86);
            this.CashierName.Name = "CashierName";
            this.CashierName.Size = new System.Drawing.Size(209, 20);
            this.CashierName.TabIndex = 16;
            this.CashierName.Text = "Ф.І.";
            this.CashierName.TextChanged += new System.EventHandler(this.CashierName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Товар:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(631, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Кількість на складі: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(631, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Вартість:";
            // 
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CashierName);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.AddToBasket);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.ProductsList);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Cashier_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Actions;
        private System.Windows.Forms.ComboBox Number;
        private System.Windows.Forms.ListBox ProductsList;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AddToBasket;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox CashierName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}