namespace UASPBO
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPasssword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.tbEmail.Location = new System.Drawing.Point(38, 309);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(320, 32);
            this.tbEmail.TabIndex = 0;
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.tbPassword.Location = new System.Drawing.Point(40, 391);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(320, 32);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(34, 277);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email  :";
            // 
            // lblPasssword
            // 
            this.lblPasssword.AutoSize = true;
            this.lblPasssword.Location = new System.Drawing.Point(34, 361);
            this.lblPasssword.Name = "lblPasssword";
            this.lblPasssword.Size = new System.Drawing.Size(90, 20);
            this.lblPasssword.TabIndex = 3;
            this.lblPasssword.Text = "Password  :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(124, 476);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(137, 54);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(429, 88);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(84, 29);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasssword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbEmail);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPasssword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

