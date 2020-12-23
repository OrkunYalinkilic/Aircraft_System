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
    public partial class BiletOnayFatura : Form
    {
        Kullanici aktifKullanici;
        UcakSefer aktifUcakSefer;
        UcakSeferKoltuk aktifUcakSeferKoltuk;

        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
        public BiletOnayFatura(Kullanici _aktifKullanici, UcakSefer _aktifUcakSefer, UcakSeferKoltuk _aktifUcakSeferKoltuk)
        {
            aktifKullanici = _aktifKullanici;
            aktifUcakSefer = _aktifUcakSefer;
            aktifUcakSeferKoltuk = _aktifUcakSeferKoltuk;
            InitializeComponent();
        }

        private void BiletOnayFatura_Load(object sender, EventArgs e)
        {
            labelBiletAd.Text = aktifKullanici.adi;
            labelBiletSoyad.Text = aktifKullanici.soyadi;
            labelBiletCepTelNo.Text = aktifKullanici.cepTelefonNumara;
            labelBiletTckimlikNo.Text = aktifKullanici.tcKimlikNo;

            labelBiletHareketYer.Text = aktifUcakSefer.UcakNeredenYer;
            labelBiletVarisYer.Text = aktifUcakSefer.UcakNereyeYer;
            labelBiletKalkisTarih.Text = aktifUcakSefer.UcakKalkisTarih;
            labelBiletKalkisSaat.Text = aktifUcakSefer.UcakKalkisSaat;
            labelBiletVarisSaat.Text = aktifUcakSefer.UcakVarisSaat;
            labelBiletKoltukNo.Text = aktifUcakSeferKoltuk.koltukNumara.ToString();
            labelBiletFiyati.Text = aktifUcakSefer.UcakSeferUcret.ToString() + " TL";
        }

        private void buttonBiletOnay_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteCommand komutKoltuk = new SQLiteCommand("update UcakKoltukDurum set KoltukDurum=1, KoltukSahibiID=@p1 where UcakSeferID=@p2 and KoltukNo=@p3", con);
            komutKoltuk.Parameters.AddWithValue("@p1", aktifKullanici.kullaniciID);
            komutKoltuk.Parameters.AddWithValue("@p2", aktifUcakSeferKoltuk.UcakSeferID);
            komutKoltuk.Parameters.AddWithValue("@p3", aktifUcakSeferKoltuk.koltukNumara);
            komutKoltuk.ExecuteNonQuery();
            con.Close();

            con.Open();
            SQLiteCommand komutBilet = new SQLiteCommand("insert into Bilet(KullaniciID,UcakSeferID,KoltukNumarasi) values(@p1,@p2,@p3)", con);
            komutBilet.Parameters.AddWithValue("@p1", aktifKullanici.kullaniciID);
            komutBilet.Parameters.AddWithValue("@p2", aktifUcakSeferKoltuk.UcakSeferID);
            komutBilet.Parameters.AddWithValue("@p3", aktifUcakSeferKoltuk.koltukNumara);
            komutBilet.ExecuteNonQuery();
            con.Close();

            Application.OpenForms["UcakBiletiAl"].Close();
            Application.OpenForms["BiletKoltukSecimi"].Close();
            Application.OpenForms["BiletOnayFatura"].Close();

            MessageBox.Show("Biletiniz Onaylandı.\nBiletlerim menüsünden biletinize ulaşabilirsiniz", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonBiletRed_Click(object sender, EventArgs e)
        {

        }
    }
}
