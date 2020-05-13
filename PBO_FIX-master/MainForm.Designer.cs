namespace UASPBO
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnBuatKeluhan = new System.Windows.Forms.Button();
            this.btnCariDokter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang,";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblNama.Location = new System.Drawing.Point(22, 51);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(131, 28);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "Nama Akun";
            this.lblNama.Click += new System.EventHandler(this.lblNama_Click);
            // 
            // btnBuatKeluhan
            // 
            this.btnBuatKeluhan.Location = new System.Drawing.Point(63, 158);
            this.btnBuatKeluhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuatKeluhan.Name = "btnBuatKeluhan";
            this.btnBuatKeluhan.Size = new System.Drawing.Size(276, 34);
            this.btnBuatKeluhan.TabIndex = 2;
            this.btnBuatKeluhan.Text = "Buat Keluhan";
            this.btnBuatKeluhan.UseVisualStyleBackColor = true;
            this.btnBuatKeluhan.Click += new System.EventHandler(this.btnBuatKeluhan_Click);
            // 
            // btnCariDokter
            // 
            this.btnCariDokter.Location = new System.Drawing.Point(63, 228);
            this.btnCariDokter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCariDokter.Name = "btnCariDokter";
            this.btnCariDokter.Size = new System.Drawing.Size(276, 33);
            this.btnCariDokter.TabIndex = 3;
            this.btnCariDokter.Text = "Cari Dokter";
            this.btnCariDokter.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCariDokter);
            this.Controls.Add(this.btnBuatKeluhan);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Button btnBuatKeluhan;
        private System.Windows.Forms.Button btnCariDokter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}