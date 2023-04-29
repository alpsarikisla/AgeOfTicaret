using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeOfTicaret
{
    public partial class UrunIslemleriForm : Form
    {
        DataModel dm = new DataModel();
        public UrunIslemleriForm()
        {
            InitializeComponent();
        }

        private void UrunIslemleriForm_Load(object sender, EventArgs e)
        {
            
            dgv_products.DataSource = dm.ProductList();
            //dgv_products.Columns[1].Visible = false;
            //dgv_products.Columns[3].Visible = false;
            //dgv_products.Columns[5].Visible = false;
            //dgv_products.Columns[13].Visible = false;
            GridDoldur();

            cb_kategori.ValueMember = "CategoryID";
            cb_kategori.DisplayMember = "CategoryName";
            cb_kategori.DataSource = dm.GetCategories();

            cb_tedarikci.ValueMember = "ID";
            cb_tedarikci.DisplayMember = "companyName";
            cb_tedarikci.DataSource = dm.SupplierList();


        }

        private void GridDoldur()
        {
            List<Product> urunler = dm.ProductList();
            DataTable dt = new DataTable();

            dt.Columns.Add("ID");
            dt.Columns.Add("Barkod No");
            dt.Columns.Add("Ürün Adi");
            dt.Columns.Add("Kategori");
            dt.Columns.Add("Tedarikçi");
            dt.Columns.Add("Stok");
            dt.Columns.Add("Fiyat");
            dt.Columns.Add("Satış Durum");
            dt.Columns.Add("Ürün Resim", typeof(byte[]));
           

            for (int i = 0; i < urunler.Count; i++)
            {
                DataRow r = dt.NewRow();
                r["ID"] = urunler[i].ProductID;
                r["Ürün Adi"] = urunler[i].ProductName;
                r["Satış Durum"] = urunler[i].Discontinued ? "Satışta Değil" : "Satışta";
                r["Barkod No"] = urunler[i].Barcode;
                r["Kategori"] = urunler[i].Category;
                r["Tedarikçi"] = urunler[i].Supplier;
                r["Stok"] = urunler[i].UnitsInStock;
                r["Fiyat"] = urunler[i].UnitPrice;
                
                Image img = Image.FromFile("../../ProductImages/" + urunler[i].ImagePath);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Gif);
                r["Ürün Resim"] = ms.ToArray();
                dt.Rows.Add(r);
                
            }
            dgv_products.DataSource = dt;
        }
    }
}
