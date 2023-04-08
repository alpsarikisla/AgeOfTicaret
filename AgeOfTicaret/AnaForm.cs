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
        }

        private void TSMI_Kategoriler_Click(object sender, EventArgs e)
        {
            KategoriIslemleriForm frm = new KategoriIslemleriForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
