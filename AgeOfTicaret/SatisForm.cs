using AgeOfTicaret.Model;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfTicaret
{
    public partial class SatisForm : Form
    {
        DataModel dm = new DataModel();
        List<TempOrder> Orders = new List<TempOrder>();
        public SatisForm()
        {
            InitializeComponent();
            FastProductDoldur();
        }

        private void tb_barkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Product p = dm.GetProduct(tb_barkod.Text);
                Orders.Add(new TempOrder() { ID = p.ProductID, Barcode = p.Barcode, Name = p.ProductName, Price = p.UnitPrice, Quantity = Convert.ToInt32(nud_adet.Value), Total = p.UnitPrice * Convert.ToInt32(nud_adet.Value) });
                tb_barkod.Text = "";
                nud_adet.Value = 1;
                tb_birimFiyat.Text = p.UnitPrice.ToString();
                GridDoldur();
            }
        }
        public void GridDoldur()
        {
            //8697419970035
            //9002490207960

            decimal toplam = 0;
            decimal Kdv = 0;
            decimal geneltoplam = 0;
            DataTable dt = new DataTable();

            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Ürün Adi");
            dt.Columns.Add("Adet");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Toplam");

            for (int i = 0; i < Orders.Count; i++)
            {
                DataRow r = dt.NewRow();
                r["Barkod No"] = Orders[i].Barcode;
                r["Ürün Adi"] = Orders[i].Name;
                r["Adet"] = Orders[i].Quantity;
                r["Fiyat"] = Orders[i].Price;
                r["Toplam"] = Orders[i].Total;
                dt.Rows.Add(r);
                toplam += Orders[i].Total;
            }
            dataGridView1.DataSource = dt;
            tb_Aratoplam.Text = toplam.ToString();

            Kdv = toplam * 0.18m;
            geneltoplam = toplam * 1.18m;

            tb_Kdv.Text = Kdv.ToString();
            tb_toplam.Text = geneltoplam.ToString();
        }

        public void FastProductDoldur()
        {
            List<Product> fasts = dm.ProductList(true);

            foreach (Product item in fasts)
            {
                UcProductView kontrol = new UcProductView();
                Image BackgroundImage = Image.FromFile("../../ProductImages/" + item.ImagePath);
                kontrol.BackgroundImage = BackgroundImage;
                kontrol.lbl_isim.Text = item.ProductName;
                kontrol.lbl_fiyat.Text = item.UnitPrice.ToString() + " TL";
                kontrol.lbl_barkod.Text = item.Barcode;
                kontrol.Click += Kontrol_Click;
                
                flowLayoutPanel1.Controls.Add(kontrol);
            }
        }

        private void Pb_resim_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Kontrol_Click(object sender, EventArgs e)
        {
            UcProductView urun = (UcProductView)sender;
            Product p = dm.GetProduct(urun.lbl_barkod.Text);
            Orders.Add(new TempOrder() { ID = p.ProductID, Barcode = p.Barcode, Name = p.ProductName, Price = p.UnitPrice, Quantity = Convert.ToInt32(nud_adet.Value), Total = p.UnitPrice * Convert.ToInt32(nud_adet.Value) });
            tb_birimFiyat.Text = p.UnitPrice.ToString();
            GridDoldur();
        }
    }
}
