namespace UASPBO
{
    partial class LandingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LandingForm));
            this.btnSignUp = new System.Windows.Forms.Button();
            this.linkSignIn = new System.Windows.Forms.LinkLabel();
            this.lblAlready = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(48, 456);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(304, 66);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "Creat an Account";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // linkSignIn
            // 
            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Location = new System.Drawing.Point(275, 432);
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.Size = new System.Drawing.Size(59, 20);
            this.linkSignIn.TabIndex = 1;
            this.linkSignIn.TabStop = true;
            this.linkSignIn.Text = "Sign In";
            this.linkSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);
            // 
            // lblAlready
            // 
            this.lblAlready.AutoSize = true;
            this.lblAlready.Location = new System.Drawing.Point(72, 432);
            this.lblAlready.Name = "lblAlready";
            this.lblAlready.Size = new System.Drawing.Size(197, 20);
            this.lblAlready.TabIndex = 2;
            this.lblAlready.Text = "Already Have an Account?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAlready);
            this.Controls.Add(this.linkSignIn);
            this.Controls.Add(this.btnSignUp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LandingForm";
            this.Text = "LandingForm";
            this.Load += new System.EventHandler(this.LandingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.LinkLabel linkSignIn;
        private System.Windows.Forms.Label lblAlready;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}