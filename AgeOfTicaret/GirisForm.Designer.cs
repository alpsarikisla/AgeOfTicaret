namespace AgeOfTicaret
{
    partial class GirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.btn_giri = new System.Windows.Forms.Button();
            this.tb_sifre = new System.Windows.Forms.TextBox();
            this.tb_kullaniciAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_kapat);
            this.groupBox1.Controls.Add(this.btn_giri);
            this.groupBox1.Controls.Add(this.tb_sifre);
            this.groupBox1.Controls.Add(this.tb_kullaniciAdi);
            this.groupBox1.Location = new System.Drawing.Point(278, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Giriş Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btn_kapat
            // 
            this.btn_kapat.Location = new System.Drawing.Point(244, 123);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(86, 23);
            this.btn_kapat.TabIndex = 1;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // btn_giri
            // 
            this.btn_giri.Location = new System.Drawing.Point(116, 123);
            this.btn_giri.Name = "btn_giri";
            this.btn_giri.Size = new System.Drawing.Size(126, 23);
            this.btn_giri.TabIndex = 1;
            this.btn_giri.Text = "Giriş Yap";
            this.btn_giri.UseVisualStyleBackColor = true;
            this.btn_giri.Click += new System.EventHandler(this.btn_giri_Click);
            // 
            // tb_sifre
            // 
            this.tb_sifre.Location = new System.Drawing.Point(116, 97);
            this.tb_sifre.Name = "tb_sifre";
            this.tb_sifre.Size = new System.Drawing.Size(214, 20);
            this.tb_sifre.TabIndex = 0;
            this.tb_sifre.Text = "1234";
            this.tb_sifre.UseSystemPasswordChar = true;
            // 
            // tb_kullaniciAdi
            // 
            this.tb_kullaniciAdi.Location = new System.Drawing.Point(116, 71);
            this.tb_kullaniciAdi.Name = "tb_kullaniciAdi";
            this.tb_kullaniciAdi.Size = new System.Drawing.Size(214, 20);
            this.tb_kullaniciAdi.TabIndex = 0;
            this.tb_kullaniciAdi.Text = "admin";
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 298);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(683, 337);
            this.Name = "GirisForm";
            this.ShowInTaskbar = false;
            this.Text = "Age Of Ticaret Giriş";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GirisForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_giri;
        private System.Windows.Forms.TextBox tb_sifre;
        private System.Windows.Forms.TextBox tb_kullaniciAdi;
        private System.Windows.Forms.Button btn_kapat;
    }
}