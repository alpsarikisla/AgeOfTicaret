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
    public partial class UrunIslemleriForm : Form
    {
        public UrunIslemleriForm()
        {
            InitializeComponent();
        }

        private void UrunIslemleriForm_Load(object sender, EventArgs e)
        {
            Icon = new System.Drawing.Icon("../../Resimler/producticon.ico");
        }
    }
}
