namespace WindowsFormsApplication19
{
    partial class Login
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
            this.SportsEat = new System.Windows.Forms.Label();
            this.labelshop = new System.Windows.Forms.Label();
            this.LoginName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Enter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SportsEat
            // 
            this.SportsEat.AutoSize = true;
            this.SportsEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SportsEat.ForeColor = System.Drawing.Color.Red;
            this.SportsEat.Location = new System.Drawing.Point(123, 9);
            this.SportsEat.Name = "SportsEat";
            this.SportsEat.Size = new System.Drawing.Size(205, 39);
            this.SportsEat.TabIndex = 0;
            this.SportsEat.Text = "\"SportsEat\"";
            // 
            // labelshop
            // 
            this.labelshop.AutoSize = true;
            this.labelshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelshop.ForeColor = System.Drawing.Color.Red;
            this.labelshop.Location = new System.Drawing.Point(109, 48);
            this.labelshop.Name = "labelshop";
            this.labelshop.Size = new System.Drawing.Size(232, 20);
            this.labelshop.TabIndex = 1;
            this.labelshop.Text = "Магазин спортивних добавок";
            // 
            // LoginName
            // 
            this.LoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginName.ForeColor = System.Drawing.Color.Gray;
            this.LoginName.Location = new System.Drawing.Point(104, 127);
            this.LoginName.Multiline = true;
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(300, 27);
            this.LoginName.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(104, 163);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(300, 27);
            this.Password.TabIndex = 4;
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Red;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.ForeColor = System.Drawing.Color.White;
            this.Enter.Location = new System.Drawing.Point(147, 222);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(124, 34);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Увійти";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 300);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginName);
            this.Controls.Add(this.labelshop);
            this.Controls.Add(this.SportsEat);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SportsEat;
        private System.Windows.Forms.Label labelshop;
        private System.Windows.Forms.TextBox LoginName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

