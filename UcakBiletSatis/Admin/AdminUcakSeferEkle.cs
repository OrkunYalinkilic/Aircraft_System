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
    public partial class AdminUcakSeferEkle : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");


        public AdminUcakSeferEkle()
        {
            InitializeComponent();
        }

        private void btnUcakSeferEkle_Click(object sender, EventArgs e)
        {
            UcakSefer ucakSefer = new UcakSefer();

            ucakSefer.UcakNeredenYer = TxtHareketYeri.Text;
            ucakSefer.UcakNereyeYer = TxtVarisYeri.Text;
            ucakSefer.UcakKalkisTarih = MskKalkisTarihi.Text;
            ucakSefer.UcakKalkisSaat = mskKalkisSaati.Text;
            ucakSefer.UcakVarisSaat = mskVarisSaati.Text;

            if (string.IsNullOrEmpty(mskBiletFiyati.Text)) mskBiletFiyati.Text = "0";

            if (ucakSefer.boslukKontrol() == true)
            {
                if (mskKalkisSaati.Text.Count() < 4 || mskVarisSaati.Text.Count() < 4 || MskKalkisTarihi.Text.Count() < 5 || mskBiletFiyati.Text == "0")
                    MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (YardimciSinif.stringKontrol(ucakSefer.UcakNeredenYer, ucakSefer.UcakNereyeYer) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    ucakSefer.UcakSeferUcret = int.Parse(mskBiletFiyati.Text);
                    con.Open();
                    SQLiteCommand komutKaydet = new SQLiteCommand("insert into UcakSefer(UcakNeredenYer,UcakNereyeYer,UcakKalkisTarih,UcakKalkisSaat,UcakVarisSaat,UcakSeferUcret) values (@p1,@p2,@p3,@p4,@p5,@p6)", con);
                    komutKaydet.Parameters.AddWithValue("@p1", ucakSefer.UcakNeredenYer);
                    komutKaydet.Parameters.AddWithValue("@p2", ucakSefer.UcakNereyeYer);
                    komutKaydet.Parameters.AddWithValue("@p3", ucakSefer.UcakKalkisTarih);
                    komutKaydet.Parameters.AddWithValue("@p4", ucakSefer.UcakKalkisSaat);
                    komutKaydet.Parameters.AddWithValue("@p5", ucakSefer.UcakVarisSaat);
                    komutKaydet.Parameters.AddWithValue("@p6", ucakSefer.UcakSeferUcret);
                    komutKaydet.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sefer Ekleme islemi gerceklestirildi..", "Sefer Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void AdminUcakSeferEkle_Load(object sender, EventArgs e)
        {
        }

        private void mskBiletFiyati_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
