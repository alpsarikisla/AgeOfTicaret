namespace AgeOfTicaret
{
    partial class UrunIslemleriForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunIslemleriForm));
            this.dgv_products = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_tedarikciEkle = new System.Windows.Forms.Button();
            this.btn_kategoriEkle = new System.Windows.Forms.Button();
            this.cb_satista = new System.Windows.Forms.CheckBox();
            this.cb_tedarikci = new System.Windows.Forms.ComboBox();
            this.cb_kategori = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_guvenlikstok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_fiyat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_birimbasinamiktar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_barkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_fast = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_products
            // 
            this.dgv_products.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_products.Location = new System.Drawing.Point(12, 206);
            this.dgv_products.Name = "dgv_products";
            this.dgv_products.Size = new System.Drawing.Size(1059, 232);
            this.dgv_products.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pb_resim);
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_tedarikciEkle);
            this.groupBox1.Controls.Add(this.btn_kategoriEkle);
            this.groupBox1.Controls.Add(this.cb_fast);
            this.groupBox1.Controls.Add(this.cb_satista);
            this.groupBox1.Controls.Add(this.cb_tedarikci);
            this.groupBox1.Controls.Add(this.cb_kategori);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_guvenlikstok);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_fiyat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tb_stok);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tb_birimbasinamiktar);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_barkod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 188);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // pb_resim
            // 
            this.pb_resim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_resim.Location = new System.Drawing.Point(655, 29);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(116, 126);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resim.TabIndex = 6;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(554, 132);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_tedarikciEkle
            // 
            this.btn_tedarikciEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_tedarikciEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tedarikciEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_tedarikciEkle.Location = new System.Drawing.Point(275, 135);
            this.btn_tedarikciEkle.Name = "btn_tedarikciEkle";
            this.btn_tedarikciEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_tedarikciEkle.TabIndex = 4;
            this.btn_tedarikciEkle.Text = "+";
            this.btn_tedarikciEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_tedarikciEkle.UseVisualStyleBackColor = false;
            // 
            // btn_kategoriEkle
            // 
            this.btn_kategoriEkle.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_kategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kategoriEkle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_kategoriEkle.Location = new System.Drawing.Point(275, 108);
            this.btn_kategoriEkle.Name = "btn_kategoriEkle";
            this.btn_kategoriEkle.Size = new System.Drawing.Size(20, 20);
            this.btn_kategoriEkle.TabIndex = 4;
            this.btn_kategoriEkle.Text = "+";
            this.btn_kategoriEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kategoriEkle.UseVisualStyleBackColor = false;
            // 
            // cb_satista
            // 
            this.cb_satista.AutoSize = true;
            this.cb_satista.Location = new System.Drawing.Point(438, 136);
            this.cb_satista.Name = "cb_satista";
            this.cb_satista.Size = new System.Drawing.Size(58, 17);
            this.cb_satista.TabIndex = 3;
            this.cb_satista.Text = "Satışta";
            this.cb_satista.UseVisualStyleBackColor = true;
            // 
            // cb_tedarikci
            // 
            this.cb_tedarikci.FormattingEnabled = true;
            this.cb_tedarikci.Location = new System.Drawing.Point(78, 135);
            this.cb_tedarikci.Name = "cb_tedarikci";
            this.cb_tedarikci.Size = new System.Drawing.Size(191, 21);
            this.cb_tedarikci.TabIndex = 2;
            // 
            // cb_kategori
            // 
            this.cb_kategori.FormattingEnabled = true;
            this.cb_kategori.Location = new System.Drawing.Point(78, 108);
            this.cb_kategori.Name = "cb_kategori";
            this.cb_kategori.Size = new System.Drawing.Size(191, 21);
            this.cb_kategori.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tedarikçi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kategori:";
            // 
            // tb_guvenlikstok
            // 
            this.tb_guvenlikstok.Location = new System.Drawing.Point(438, 82);
            this.tb_guvenlikstok.Name = "tb_guvenlikstok";
            this.tb_guvenlikstok.Size = new System.Drawing.Size(191, 20);
            this.tb_guvenlikstok.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Stoğu:";
            // 
            // tb_fiyat
            // 
            this.tb_fiyat.Location = new System.Drawing.Point(438, 108);
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.Size = new System.Drawing.Size(191, 20);
            this.tb_fiyat.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Satış Durum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(374, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Satış Fiyat:";
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(438, 56);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(191, 20);
            this.tb_stok.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Stok :";
            // 
            // tb_birimbasinamiktar
            // 
            this.tb_birimbasinamiktar.Location = new System.Drawing.Point(438, 30);
            this.tb_birimbasinamiktar.Name = "tb_birimbasinamiktar";
            this.tb_birimbasinamiktar.Size = new System.Drawing.Size(191, 20);
            this.tb_birimbasinamiktar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Birim Başına Miktar:";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(78, 82);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(191, 20);
            this.tb_isim.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adı:";
            // 
            // tb_barkod
            // 
            this.tb_barkod.Location = new System.Drawing.Point(78, 56);
            this.tb_barkod.Name = "tb_barkod";
            this.tb_barkod.Size = new System.Drawing.Size(191, 20);
            this.tb_barkod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barkod No:";
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(78, 30);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(191, 20);
            this.tb_ID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(365, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Hızlı Satış";
            // 
            // cb_fast
            // 
            this.cb_fast.AutoSize = true;
            this.cb_fast.Location = new System.Drawing.Point(438, 159);
            this.cb_fast.Name = "cb_fast";
            this.cb_fast.Size = new System.Drawing.Size(47, 17);
            this.cb_fast.TabIndex = 3;
            this.cb_fast.Text = "Ekle";
            this.cb_fast.UseVisualStyleBackColor = true;
            // 
            // UrunIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_products);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UrunIslemleriForm";
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.UrunIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_products)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_products;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_tedarikciEkle;
        private System.Windows.Forms.Button btn_kategoriEkle;
        private System.Windows.Forms.CheckBox cb_satista;
        private System.Windows.Forms.ComboBox cb_tedarikci;
        private System.Windows.Forms.ComboBox cb_kategori;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_guvenlikstok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_fiyat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_birimbasinamiktar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_barkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox cb_fast;
        private System.Windows.Forms.Label label11;
    }
}