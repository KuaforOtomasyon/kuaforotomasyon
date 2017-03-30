using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KuaforOtomasyon.Formlar;

namespace KuaforOtomasyon
{
    public partial class Index : DevExpress.XtraEditors.XtraForm
    {
        public Index()
        {
            InitializeComponent();
        }

        public void IslemlerPencereAcilis(object sender, EventArgs e)
        {
            Islemler IslemPencere= new Islemler();
            IslemPencere.MdiParent = this;
            IslemPencere.Show();
        }

        private void MusteriEklePencere(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MusteriEkle musteriekle = new MusteriEkle();
            musteriekle.MdiParent = this;
            musteriekle.Show();
        }
    }
}