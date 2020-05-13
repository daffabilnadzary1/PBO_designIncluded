namespace UASPBO
{
    partial class KeluhanBerhasilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeluhanBerhasilForm));
            this.btnKonsultasi = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKonsultasi
            // 
            this.btnKonsultasi.Location = new System.Drawing.Point(131, 481);
            this.btnKonsultasi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKonsultasi.Name = "btnKonsultasi";
            this.btnKonsultasi.Size = new System.Drawing.Size(140, 36);
            this.btnKonsultasi.TabIndex = 0;
            this.btnKonsultasi.Text = "Konsultasi";
            this.btnKonsultasi.UseVisualStyleBackColor = true;
            this.btnKonsultasi.Click += new System.EventHandler(this.btnKonsultasi_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(131, 537);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(140, 37);
            this.btnKembali.TabIndex = 1;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // KeluhanBerhasilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnKonsultasi);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KeluhanBerhasilForm";
            this.Text = "KeluhanBerhasilForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKonsultasi;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}