using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfTicaret
{
    public partial class KategoriIslemleriForm : Form
    {
        DataModel dm = new DataModel();
        int id = -1;
        public KategoriIslemleriForm()
        {
            InitializeComponent();
        }

        private void KategoriIslemleriForm_Load(object sender, EventArgs e)
        {
            #region witout DataModel

            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=NORTHWND; Integrated Security=True");
            //DataSet ds = new DataSet();
            //SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryName,Picture FROM Categories", con);
            //con.Open();
            //da.Fill(ds);
            //dataGridView1.DataSource = ds.Tables[0];
            //con.Close();

            #endregion

            dataGridView1.DataSource = dm.GetCategories();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_isim.Text.Trim()))
            {
                Category model = new Category();
                model.CategoryName = tb_isim.Text;
                model.Description = tb_aciklama.Text;
                model = dm.AddCategory(model);
                if (model.CategoryID != 0)
                {
                    MessageBox.Show($"kategori {model.CategoryID} id ile başarıyla eklenmiştir", "Başarılı");
                    tb_aciklama.Text = tb_isim.Text = "";
                    dataGridView1.DataSource = dm.GetCategories();
                }
                else
                {
                    MessageBox.Show("kategori Eklenirken bir hata oluştu", "Hata Oluştu");
                }
            }
            else
            {
                MessageBox.Show("İsim Boş Olamaz", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                var yer = dataGridView1.HitTest(e.X, e.Y);
                if (yer.RowIndex != -1)
                {
                    //MessageBox.Show("Seçilen Satır = " + yer.RowIndex.ToString());
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[yer.RowIndex].Selected = true;
                    id = Convert.ToInt32(dataGridView1.Rows[yer.RowIndex].Cells[0].Value);
                    contextMenuStrip1.Show(dataGridView1, e.X, e.Y);
                }
            }
        }

        private void TSMI_Guncelle_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                Category c = dm.GetCategory(id);
                tb_id.Text = c.CategoryID.ToString();
                tb_isim.Text = c.CategoryName;
                tb_aciklama.Text = c.Description;
                btn_guncelle.Visible = true;
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                //Category c = dm.GetCategory(id);
                Category c = new Category();
                c.CategoryID = int.Parse(tb_id.Text);
                c.CategoryName = tb_isim.Text;
                c.Description = tb_aciklama.Text;
                if (dm.UpdateCategory(c))
                {
                    tb_id.Text = tb_isim.Text = tb_aciklama.Text = "";
                    btn_guncelle.Visible = false;
                    MessageBox.Show("Güncelleme işlemi başarılı", "Başarılı");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi başarısız", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridView1.DataSource = dm.GetCategories();
            }
        }

        private void TSMI_Sil_Click(object sender, EventArgs e)
        {
            if (id != -1)
            {
                if (MessageBox.Show($"{id} idli kategori silinecektir. Emin misiniz?", "Sil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dm.RemoveCategory(id);
                }
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi", "İptal");
                }
            }
            dataGridView1.DataSource = dm.GetCategories();
        }
    }
}
