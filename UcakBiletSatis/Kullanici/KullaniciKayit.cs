using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace UcakBiletSatis
{
    public partial class KullaniciKayit : Form
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtOgrSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();

            kullanici.adi = TxtAd.Text;
            kullanici.soyadi = TxtSoyad.Text;
            kullanici.tcKimlikNo = MskKullaniciTc.Text;
            kullanici.cepTelefonNumara = MskKullaniciTelefon.Text;
            kullanici.kullaniciAdi = txtKullaniciAdi.Text;
            kullanici.sifre = txtSifre.Text;

            if (kullanici.boslukKontrol() == true)
            {
                if (YardimciSinif.stringKontrol(kullanici.adi, kullanici.soyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    SQLiteCommand komutKaydet = new SQLiteCommand("insert into Kullanici (Adi,Soyadi,TcKimlikNumarasi,CepNumarasi,KullaniciAdi,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    komutKaydet.Parameters.AddWithValue("@p1", kullanici.adi);
                    komutKaydet.Parameters.AddWithValue("@p2", kullanici.soyadi);
                    komutKaydet.Parameters.AddWithValue("@p3", kullanici.tcKimlikNo);
                    komutKaydet.Parameters.AddWithValue("@p4", kullanici.cepTelefonNumara);
                    komutKaydet.Parameters.AddWithValue("@p5", kullanici.kullaniciAdi);
                    komutKaydet.Parameters.AddWithValue("@p6", kullanici.sifre);
                    komutKaydet.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Kayit islemi gerceklestirildi..", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
            
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void KullaniciKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
