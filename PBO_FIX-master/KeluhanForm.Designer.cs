namespace UASPBO
{
    partial class KeluhanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeluhanForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKeluhan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1Hari = new System.Windows.Forms.CheckBox();
            this.cb2Minggu = new System.Windows.Forms.CheckBox();
            this.cb2Hari = new System.Windows.Forms.CheckBox();
            this.cb1Minggu = new System.Windows.Forms.CheckBox();
            this.rtbKeluhan = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInputKeluhan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buat Keluhan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Keluhan";
            // 
            // cmbKeluhan
            // 
            this.cmbKeluhan.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKeluhan.FormattingEnabled = true;
            this.cmbKeluhan.Items.AddRange(new object[] {
            "Penyakit Jantung",
            "Penyakit Kulit",
            "Penyakit THT",
            "Penyakit Pencernaan",
            "Penyakit Gigi"});
            this.cmbKeluhan.Location = new System.Drawing.Point(22, 156);
            this.cmbKeluhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbKeluhan.Name = "cmbKeluhan";
            this.cmbKeluhan.Size = new System.Drawing.Size(225, 26);
            this.cmbKeluhan.TabIndex = 2;
            this.cmbKeluhan.SelectedIndexChanged += new System.EventHandler(this.cmbKeluhan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lama Sakit";
            // 
            // cb1Hari
            // 
            this.cb1Hari.AutoSize = true;
            this.cb1Hari.Location = new System.Drawing.Point(23, 221);
            this.cb1Hari.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb1Hari.Name = "cb1Hari";
            this.cb1Hari.Size = new System.Drawing.Size(54, 17);
            this.cb1Hari.TabIndex = 4;
            this.cb1Hari.Text = "1 Hari";
            this.cb1Hari.UseVisualStyleBackColor = true;
            // 
            // cb2Minggu
            // 
            this.cb2Minggu.AutoSize = true;
            this.cb2Minggu.Location = new System.Drawing.Point(165, 249);
            this.cb2Minggu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb2Minggu.Name = "cb2Minggu";
            this.cb2Minggu.Size = new System.Drawing.Size(76, 17);
            this.cb2Minggu.TabIndex = 5;
            this.cb2Minggu.Text = ">2 Minggu";
            this.cb2Minggu.UseVisualStyleBackColor = true;
            // 
            // cb2Hari
            // 
            this.cb2Hari.AutoSize = true;
            this.cb2Hari.Location = new System.Drawing.Point(165, 221);
            this.cb2Hari.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb2Hari.Name = "cb2Hari";
            this.cb2Hari.Size = new System.Drawing.Size(63, 17);
            this.cb2Hari.TabIndex = 6;
            this.cb2Hari.Text = "2-3 Hari";
            this.cb2Hari.UseVisualStyleBackColor = true;
            // 
            // cb1Minggu
            // 
            this.cb1Minggu.AutoSize = true;
            this.cb1Minggu.Location = new System.Drawing.Point(24, 249);
            this.cb1Minggu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb1Minggu.Name = "cb1Minggu";
            this.cb1Minggu.Size = new System.Drawing.Size(70, 17);
            this.cb1Minggu.TabIndex = 7;
            this.cb1Minggu.Text = "1 Minggu";
            this.cb1Minggu.UseVisualStyleBackColor = true;
            // 
            // rtbKeluhan
            // 
            this.rtbKeluhan.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbKeluhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(176)))), ((int)(((byte)(185)))));
            this.rtbKeluhan.Location = new System.Drawing.Point(21, 309);
            this.rtbKeluhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbKeluhan.Name = "rtbKeluhan";
            this.rtbKeluhan.Size = new System.Drawing.Size(227, 127);
            this.rtbKeluhan.TabIndex = 8;
            this.rtbKeluhan.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Deskripsi Tambahan";
            // 
            // btnInputKeluhan
            // 
            this.btnInputKeluhan.Location = new System.Drawing.Point(135, 452);
            this.btnInputKeluhan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInputKeluhan.Name = "btnInputKeluhan";
            this.btnInputKeluhan.Size = new System.Drawing.Size(112, 35);
            this.btnInputKeluhan.TabIndex = 10;
            this.btnInputKeluhan.Text = "Input";
            this.btnInputKeluhan.UseVisualStyleBackColor = true;
            this.btnInputKeluhan.Click += new System.EventHandler(this.btnInputKeluhan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 522);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // KeluhanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 391);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnInputKeluhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbKeluhan);
            this.Controls.Add(this.cb1Minggu);
            this.Controls.Add(this.cb2Hari);
            this.Controls.Add(this.cb2Minggu);
            this.Controls.Add(this.cb1Hari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKeluhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "KeluhanForm";
            this.Text = "KeluhanForm";
            this.Load += new System.EventHandler(this.KeluhanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKeluhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb1Hari;
        private System.Windows.Forms.CheckBox cb2Minggu;
        private System.Windows.Forms.CheckBox cb2Hari;
        private System.Windows.Forms.CheckBox cb1Minggu;
        private System.Windows.Forms.RichTextBox rtbKeluhan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInputKeluhan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}