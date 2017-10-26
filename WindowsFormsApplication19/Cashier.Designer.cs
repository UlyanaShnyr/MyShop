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
            this.textBoxActions = new System.Windows.Forms.TextBox();
            this.AddToBasket = new System.Windows.Forms.Button();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxCashierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewProdcuts = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdcuts)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // textBoxActions
            // 
            this.textBoxActions.ForeColor = System.Drawing.Color.Gray;
            this.textBoxActions.Location = new System.Drawing.Point(284, 17);
            this.textBoxActions.Multiline = true;
            this.textBoxActions.Name = "textBoxActions";
            this.textBoxActions.Size = new System.Drawing.Size(446, 90);
            this.textBoxActions.TabIndex = 4;
            this.textBoxActions.Text = "Акції";
            // 
            // AddToBasket
            // 
            this.AddToBasket.BackColor = System.Drawing.Color.Red;
            this.AddToBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToBasket.ForeColor = System.Drawing.Color.White;
            this.AddToBasket.Location = new System.Drawing.Point(3, 19);
            this.AddToBasket.Name = "AddToBasket";
            this.AddToBasket.Size = new System.Drawing.Size(137, 29);
            this.AddToBasket.TabIndex = 12;
            this.AddToBasket.Text = "Додати в корзину";
            this.AddToBasket.UseVisualStyleBackColor = false;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.ForeColor = System.Drawing.Color.Gray;
            this.textBoxTotalPrice.Location = new System.Drawing.Point(555, 495);
            this.textBoxTotalPrice.Multiline = true;
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(175, 59);
            this.textBoxTotalPrice.TabIndex = 13;
            this.textBoxTotalPrice.Text = "Загальна вартість";
            // 
            // buttonCheck
            // 
            this.buttonCheck.BackColor = System.Drawing.Color.Red;
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheck.ForeColor = System.Drawing.Color.White;
            this.buttonCheck.Location = new System.Drawing.Point(4, 495);
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
            this.buttonExit.Location = new System.Drawing.Point(189, 495);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(177, 34);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.Exit_Click);
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
            this.label4.Location = new System.Drawing.Point(142, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Товари";
            // 
            // dataGridViewProdcuts
            // 
            this.dataGridViewProdcuts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdcuts.Location = new System.Drawing.Point(19, 162);
            this.dataGridViewProdcuts.Name = "dataGridViewProdcuts";
            this.dataGridViewProdcuts.Size = new System.Drawing.Size(354, 264);
            this.dataGridViewProdcuts.TabIndex = 20;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(146, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(147, 225);
            this.listBox1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(540, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Корзина";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AddToBasket);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(423, 162);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 264);
            this.panel1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Видалити";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(88, 105);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 20);
            this.numericUpDown1.TabIndex = 23;
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
            // Cashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(747, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewProdcuts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCashierName);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxActions);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cashier";
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdcuts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxActions;
        private System.Windows.Forms.Button AddToBasket;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxCashierName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewProdcuts;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}