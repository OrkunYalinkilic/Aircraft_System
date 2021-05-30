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
    public partial class KullaniciSifreGuncelleme : Form
    {
        Kullanici aktifKullanici;
        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        public KullaniciSifreGuncelleme(Kullanici _aktifKullanici)
        {
            aktifKullanici = _aktifKullanici;
            InitializeComponent();
        }

        private void KullaniciSifreGuncelleme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSifreYeni.Text) == true || string.IsNullOrEmpty(txtSifreEski.Text) == true || string.IsNullOrEmpty(txtSifreYeniTekrar.Text) == true)
            {
                MessageBox.Show("Değerler boş geçilemez!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtSifreEski.Text != aktifKullanici.sifre)
                {
                    MessageBox.Show("Girdiğiniz eski şifre YANLIŞ", "Hatalı Şifre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifreEski.Text = string.Empty;
                    txtSifreYeni.Text = string.Empty;
                    txtSifreYeniTekrar.Text = string.Empty;
                }


                else if (txtSifreYeni.Text.Length <= 5)
                {
                    MessageBox.Show("Yeni Şifre 5 karakterden fazla olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!txtSifreYeni.Text.Equals(txtSifreYeniTekrar.Text)) { 
                    MessageBox.Show("Yeni Şifre ve Tekrarı aynı olmalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    con.Open();
                    SQLiteCommand cmdDegistir = new SQLiteCommand("update Kullanici set Sifre=@p1 where KullaniciID=@p2", con);
                    cmdDegistir.Parameters.AddWithValue("@p1", txtSifreYeni.Text);
                    cmdDegistir.Parameters.AddWithValue("@p2", aktifKullanici.kullaniciID);
                    cmdDegistir.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Şifre değiştirildi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }
    }
}
