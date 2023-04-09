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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            GirisForm frm = new GirisForm();
            frm.ShowDialog();
            Employee model = Helpers.GirisYapanKullanici;
            TSSL_kullanici.Text = model.FullName + "(" + model.UserName  +")";
        }

        private void TSMI_Kategoriler_Click(object sender, EventArgs e)
        {
            bool acikmi = false;
            Form[] acikformlar = this.MdiChildren;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(KategoriIslemleriForm))
                {
                    acikmi = true;
                    item.Activate();
                }
            }

            if (acikmi == false)
            {
                KategoriIslemleriForm frm = new KategoriIslemleriForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void TSMI_Urunler_Click(object sender, EventArgs e)
        {
            bool acikmi = false;
            Form[] acikformlar = this.MdiChildren;

            foreach (Form item in acikformlar)
            {
                if (item.GetType() == typeof(UrunIslemleriForm))
                {
                    acikmi = true;
                    item.Activate();
                }
            }

            if (acikmi == false)
            {
                UrunIslemleriForm frm = new UrunIslemleriForm();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
