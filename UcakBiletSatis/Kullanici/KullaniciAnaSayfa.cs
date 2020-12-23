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
    public partial class KullaniciAnaSayfa : Form
    {
        string zaman;
        Timer timer1 = new Timer();
        public Kullanici aktifKullanici = new Kullanici();

        public KullaniciAnaSayfa(Kullanici _aktifKullanici)
        {
            aktifKullanici = _aktifKullanici;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           /* label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();*/

            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void KullaniciAnaSayfa_Load(object sender, EventArgs e)
        {
            timer.Start();

         //   LblAdiSoyadi.Text = aktifKullanici.adi + " " + aktifKullanici.soyadi;

            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
          
        }

        private void btnKullaniciBilgilerim_Click(object sender, EventArgs e)
        {
            KullaniciBilgilerim frm = new KullaniciBilgilerim(aktifKullanici);
            frm.ShowDialog();
        }

        private void btnUcakBiletAl_Click(object sender, EventArgs e)
        {
            UcakBiletiAl frm = new UcakBiletiAl(aktifKullanici);
            frm.ShowDialog();
        }

        private void btnUcakBiletlerim_Click(object sender, EventArgs e)
        {
            UcakBiletlerim frm = new UcakBiletlerim(aktifKullanici);
            frm.ShowDialog();
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
