namespace WindowsFormsApplication19
{
    partial class Registr
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.againpassword = new System.Windows.Forms.TextBox();
            this.Registration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(130, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "\"SportsEat\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(123, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Магазин спортивних добавок";
            // 
            // Name
            // 
            this.Name.ForeColor = System.Drawing.Color.Gray;
            this.Name.Location = new System.Drawing.Point(40, 119);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(389, 20);
            this.Name.TabIndex = 32;
            this.Name.Text = "Ім\'я";
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Surname
            // 
            this.Surname.ForeColor = System.Drawing.Color.Gray;
            this.Surname.Location = new System.Drawing.Point(40, 145);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(389, 20);
            this.Surname.TabIndex = 33;
            this.Surname.Text = "Фамілія";
            this.Surname.TextChanged += new System.EventHandler(this.Surname_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.PhoneNumber.Location = new System.Drawing.Point(40, 171);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(389, 20);
            this.PhoneNumber.TabIndex = 34;
            this.PhoneNumber.Text = "Номер телефону";
            this.PhoneNumber.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            // 
            // Login
            // 
            this.Login.ForeColor = System.Drawing.Color.Gray;
            this.Login.Location = new System.Drawing.Point(40, 197);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(389, 20);
            this.Login.TabIndex = 35;
            this.Login.Text = "логін";
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // Password
            // 
            this.Password.ForeColor = System.Drawing.Color.Gray;
            this.Password.Location = new System.Drawing.Point(40, 223);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(389, 20);
            this.Password.TabIndex = 36;
            this.Password.Text = "пароль";
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // againpassword
            // 
            this.againpassword.ForeColor = System.Drawing.Color.Gray;
            this.againpassword.Location = new System.Drawing.Point(40, 249);
            this.againpassword.Name = "againpassword";
            this.againpassword.Size = new System.Drawing.Size(389, 20);
            this.againpassword.TabIndex = 37;
            this.againpassword.Text = "повторити пароль";
            this.againpassword.TextChanged += new System.EventHandler(this.againpassword_TextChanged);
            // 
            // Registration
            // 
            this.Registration.BackColor = System.Drawing.Color.Red;
            this.Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registration.ForeColor = System.Drawing.Color.White;
            this.Registration.Location = new System.Drawing.Point(40, 292);
            this.Registration.Name = "Registration";
            this.Registration.Size = new System.Drawing.Size(213, 34);
            this.Registration.TabIndex = 38;
            this.Registration.Text = "Зареєструвати";
            this.Registration.UseVisualStyleBackColor = false;
            this.Registration.Click += new System.EventHandler(this.Registration_Click);
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.Registration);
            this.Controls.Add(this.againpassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registr";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox againpassword;
        private System.Windows.Forms.Button Registration;
    }
}