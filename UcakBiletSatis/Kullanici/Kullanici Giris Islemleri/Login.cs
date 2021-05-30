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
using UcakBiletSatis.Models__Class_;

namespace UcakBiletSatis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void grpOgrenci_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            KullaniciKayit frm = new KullaniciKayit();
            frm.ShowDialog();
        }

        private void btnGirisOgrenci_Click(object sender, EventArgs e)
        {
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.kullaniciAdi = txtKullaniciAd.Text;
            kullanici.sifre = txtParola.Text;

            LoginTuruDisplay loginTur = new LoginTuruDisplay();
            // Bu nesneyi ziyaretçi tasarım desenini kullanmak için ILoginTuru interfacesini implement ettiğim
            // LoginTuruDisplay class'ından oluşturdum. Kullanıcı türüne göre farklı bir giriş yapılmış olacak.

            if (string.IsNullOrEmpty(txtKullaniciAd.Text) || string.IsNullOrEmpty(txtParola.Text))
            {
                MessageBox.Show("Lutfen bilgileriniz EKSİKSİZ giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtKullaniciAd.Text == "admin" && txtParola.Text == "admin")
            {
                Yonetici admin = new Yonetici();
                admin.kullaniciAdi = txtKullaniciAd.Text;
                admin.sifre = txtParola.Text;

                loginTur.LogIn(admin); // parametre olarak admin gönderildiği için Admin sayfası açılacak.
            }

            else if (kullanici.LogIn(kullanici) == false)
            {
                MessageBox.Show("Hatalı Giriş Yapıldı.\n\nLütfen Geçerli Kullanıcı Adı ve Parola Giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAd.Focus();
            }
            else
            {
                loginTur.LogIn(kullanici); // parametre olarak kullanici gönderildiği için Admin sayfası açılacak.
            }

            txtKullaniciAd.Text = string.Empty;
            txtParola.Text = string.Empty;
        }

        private void txtOgrenciKullaniciAd_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
