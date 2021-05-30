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
    public partial class Admin : Form
    {
        string zaman;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnUcakBiletlerim_Click(object sender, EventArgs e)
        {
            AdminUcakSeferEkle frm = new AdminUcakSeferEkle();
            frm.ShowDialog();
        }

        private void btnUcakSeferSil_Click(object sender, EventArgs e)
        {
            AdminUcakSeferSil frm = new AdminUcakSeferSil();
            frm.ShowDialog();
        }

        private void btnUcakSeferGuncelle_Click(object sender, EventArgs e)
        {
            AdminUcakSeferGuncelle frm = new AdminUcakSeferGuncelle();
            frm.ShowDialog();

        }

        private void btnUcakSeferListele_Click(object sender, EventArgs e)
        {
            AdminSeferListele frm = new AdminSeferListele();
            frm.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

            string ay = DateTime.Now.Month.ToString();
            string yil = DateTime.Now.Year.ToString();
            zaman = ay + "-" + yil;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            timer.Start();

            //   LblAdiSoyadi.Text = aktifKullanici.adi + " " + aktifKullanici.soyadi;

            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
