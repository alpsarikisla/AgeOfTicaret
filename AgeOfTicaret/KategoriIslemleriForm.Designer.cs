namespace AgeOfTicaret
{
    partial class KategoriIslemleriForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Guncelle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_guncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 269);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_Ekle);
            this.groupBox1.Controls.Add(this.tb_aciklama);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_isim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID:";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(100, 37);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(215, 20);
            this.tb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Isim:";
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(100, 63);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(215, 20);
            this.tb_isim.TabIndex = 1;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(342, 115);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 2;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açıklama:";
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(100, 89);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(215, 49);
            this.tb_aciklama.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Guncelle,
            this.TSMI_Sil});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // TSMI_Guncelle
            // 
            this.TSMI_Guncelle.Name = "TSMI_Guncelle";
            this.TSMI_Guncelle.Size = new System.Drawing.Size(120, 22);
            this.TSMI_Guncelle.Text = "Güncelle";
            this.TSMI_Guncelle.Click += new System.EventHandler(this.TSMI_Guncelle_Click);
            // 
            // TSMI_Sil
            // 
            this.TSMI_Sil.Name = "TSMI_Sil";
            this.TSMI_Sil.Size = new System.Drawing.Size(180, 22);
            this.TSMI_Sil.Text = "Sil";
            this.TSMI_Sil.Click += new System.EventHandler(this.TSMI_Sil_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(342, 115);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(75, 23);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Visible = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // KategoriIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KategoriIslemleriForm";
            this.Text = "Kategori İşlemleri";
            this.Load += new System.EventHandler(this.KategoriIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Guncelle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sil;
        private System.Windows.Forms.Button btn_guncelle;
    }
}