using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DevExpress.XtraEditors;
using KuaforContext;
using Devart.Data.Linq;

namespace KuaforOtomasyon.Formlar
{
    public partial class MusteriEkle : DevExpress.XtraEditors.XtraForm
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                musteri data = new musteri();
                Musteri musteri = new Musteri();

                musteri.MusteriAdi = MusteriAdi.Text;
                musteri.MusteriSoyadi = MusteriSoyadi.Text;
                musteri.Cinsiyet = MusteriCinsiyet.SelectedItem.ToString();
                musteri.DogumTarihi = Convert.ToDateTime(DogumTarihi.Text);
                musteri.DogumYeri = DogumYeri.Text;
                musteri.Adres = Adres.Text;
                musteri.CepTelefon = CepTel.Text;
                musteri.EvTelefon = EvTel.Text;
                musteri.EMail = Email.Text;
                musteri.Kuafor = KuaforSec.SelectedItem.ToString();
                musteri.Iptal = iptalDurumu.SelectedItem.ToString();
                musteri.Adres = Adres.Text;
                musteri.KayitTarihi = DateTime.Now;


                data.Musteris.InsertOnSubmit(musteri);
                data.SubmitChanges();
                MessageBox.Show("Veritabanına Kaydedildi.");
            }
            catch ( ChangeConflictException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}