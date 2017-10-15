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
            this.SportsEat.Click += new System.EventHandler(this.SportsEat_Click);
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
            this.labelshop.Click += new System.EventHandler(this.labelshop_Click);
            // 
            // LoginName
            // 
            this.LoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginName.ForeColor = System.Drawing.Color.Gray;
            this.LoginName.Location = new System.Drawing.Point(37, 156);
            this.LoginName.Multiline = true;
            this.LoginName.Name = "LoginName";
            this.LoginName.Size = new System.Drawing.Size(435, 27);
            this.LoginName.TabIndex = 3;
            this.LoginName.Text = "Login";
            this.LoginName.TextChanged += new System.EventHandler(this.LoginName_TextChanged);
            this.LoginName.Enter += new System.EventHandler(this.LoginName_Enter);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(37, 189);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(435, 27);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Enter
            // 
            this.Enter.BackColor = System.Drawing.Color.Red;
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter.ForeColor = System.Drawing.Color.White;
            this.Enter.Location = new System.Drawing.Point(37, 258);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(124, 34);
            this.Enter.TabIndex = 5;
            this.Enter.Text = "Увійти";
            this.Enter.UseVisualStyleBackColor = false;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginName);
            this.Controls.Add(this.labelshop);
            this.Controls.Add(this.SportsEat);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SportsEat;
        private System.Windows.Forms.Label labelshop;
        private System.Windows.Forms.TextBox LoginName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Enter;
    }
}

