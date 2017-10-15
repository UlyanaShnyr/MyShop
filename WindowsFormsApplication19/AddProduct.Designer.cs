namespace WindowsFormsApplication19
{
    partial class AddProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Action = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.ProductsName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(133, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(140, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "\"SportsEat\"";
            // 
            // Price
            // 
            this.Price.ForeColor = System.Drawing.Color.Gray;
            this.Price.Location = new System.Drawing.Point(42, 187);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(389, 20);
            this.Price.TabIndex = 41;
            this.Price.Text = "Ціна";
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // Action
            // 
            this.Action.ForeColor = System.Drawing.Color.Gray;
            this.Action.Location = new System.Drawing.Point(42, 161);
            this.Action.Name = "Action";
            this.Action.Size = new System.Drawing.Size(389, 20);
            this.Action.TabIndex = 40;
            this.Action.Text = "Акція";
            this.Action.TextChanged += new System.EventHandler(this.Action_TextChanged);
            // 
            // Number
            // 
            this.Number.ForeColor = System.Drawing.Color.Gray;
            this.Number.Location = new System.Drawing.Point(42, 135);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(389, 20);
            this.Number.TabIndex = 39;
            this.Number.Text = "Кількість";
            this.Number.TextChanged += new System.EventHandler(this.Number_TextChanged);
            // 
            // ProductsName
            // 
            this.ProductsName.ForeColor = System.Drawing.Color.Gray;
            this.ProductsName.Location = new System.Drawing.Point(42, 109);
            this.ProductsName.Name = "ProductsName";
            this.ProductsName.Size = new System.Drawing.Size(389, 20);
            this.ProductsName.TabIndex = 38;
            this.ProductsName.Text = "Назва товару";
            this.ProductsName.TextChanged += new System.EventHandler(this.ProductsName_TextChanged);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Red;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(41, 225);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(213, 34);
            this.Save.TabIndex = 44;
            this.Save.Text = "Зберегти";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "Добавляємо новий товар";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Action);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.ProductsName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.TextChanged += new System.EventHandler(this.ProductsName_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Action;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.TextBox ProductsName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label3;
    }
}