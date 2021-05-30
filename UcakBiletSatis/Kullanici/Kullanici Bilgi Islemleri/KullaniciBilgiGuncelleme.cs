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
    public partial class KullaniciBilgiGuncelleme : Form
    {
        Kullanici aktifKullanici;
        public KullaniciBilgiGuncelleme(Kullanici _aktifKullanici)
        {
            aktifKullanici = _aktifKullanici;
            InitializeComponent();
        }
        private void KullaniciBilgiGuncelleme_Load(object sender, EventArgs e)
        {
            TxtAdGuncel.Text = aktifKullanici.adi;
            txtKullaniciAdiGuncel.Text = aktifKullanici.kullaniciAdi;
            TxtSoyadGuncel.Text = aktifKullanici.soyadi;
            MskKullaniciTcGuncel.Text = aktifKullanici.tcKimlikNo;
            MskKullaniciTelefonGuncel.Text = aktifKullanici.cepTelefonNumara;
        }

        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        private void BtnBilgiGuncelleme_Click(object sender, EventArgs e)
        {
            Kullanici user = new Kullanici();
            user.adi = TxtAdGuncel.Text;
            user.soyadi = TxtSoyadGuncel.Text;
            user.tcKimlikNo = MskKullaniciTcGuncel.Text;
            user.cepTelefonNumara = MskKullaniciTelefonGuncel.Text;
            user.kullaniciAdi = txtKullaniciAdiGuncel.Text;

            if (!String.IsNullOrEmpty(user.adi) && !String.IsNullOrEmpty(user.soyadi) && !String.IsNullOrEmpty(MskKullaniciTcGuncel.Text) 
                && !String.IsNullOrEmpty(MskKullaniciTelefonGuncel.Text) && !String.IsNullOrEmpty(txtKullaniciAdiGuncel.Text))
            {
                if (YardimciSinif.stringKontrol(user.adi, user.soyadi) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    con.Open();
                    SQLiteCommand komut = new SQLiteCommand("update Kullanici set Adi=@p1, Soyadi=@p2, TcKimlikNumarasi=@p3, CepNumarasi=@p4, KullaniciAdi=@p5  where KullaniciID=@p6", con);
                    komut.Parameters.AddWithValue("@p1", TxtAdGuncel.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSoyadGuncel.Text);
                    komut.Parameters.AddWithValue("@p3", MskKullaniciTcGuncel.Text);
                    komut.Parameters.AddWithValue("@p4", MskKullaniciTelefonGuncel.Text);
                    komut.Parameters.AddWithValue("@p5", txtKullaniciAdiGuncel.Text);
                    komut.Parameters.AddWithValue("@p6", aktifKullanici.kullaniciID);
                    //con.Clone();


                    komut.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Güncelleme işlemi gerçekleştirildi.", "Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
