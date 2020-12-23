using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletSatis
{
    
    public partial class KullaniciBilgilerim : Form
    {
        Kullanici aktifKullanici;

        public KullaniciBilgilerim(Kullanici _aktifKullanici)
        {
            aktifKullanici = _aktifKullanici;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KullaniciBilgilerim_Load(object sender, EventArgs e)
        {
            labelAdiniz.Text = aktifKullanici.adi;
            labelSoyadiniz.Text = aktifKullanici.soyadi;
            labelCepNo.Text = aktifKullanici.cepTelefonNumara;
            labelTckimlik.Text = aktifKullanici.tcKimlikNo;
            labelKullaniciAdiniz.Text = aktifKullanici.kullaniciAdi;
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciSifreGuncelleme frm = new KullaniciSifreGuncelleme(aktifKullanici);
            frm.ShowDialog();
        }

        private void btnSifreGuncelle_Click(object sender, EventArgs e)
        {
            KullaniciBilgiGuncelleme frm = new KullaniciBilgiGuncelleme(aktifKullanici);
            frm.ShowDialog();
        }
    }
}
