using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UcakBiletSatis
{
    public partial class AdminSeferGuncelleIslem : Form
    {
        //   SqlBaglanti bgl = new SqlBaglanti();

        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        UcakSefer aktifUcakSefer;
        public AdminSeferGuncelleIslem(UcakSefer _aktifUcakSefer)
        {
            aktifUcakSefer = _aktifUcakSefer;
            InitializeComponent();
        }

        private void AdminSeferGuncelleIslem_Load(object sender, EventArgs e)
        {
            TxtHareketYeri.Text = aktifUcakSefer.UcakNeredenYer;
            TxtVarisYeri.Text = aktifUcakSefer.UcakNereyeYer;
            mskKalkisSaati.Text = aktifUcakSefer.UcakKalkisSaat;
            mskVarisSaati.Text = aktifUcakSefer.UcakVarisSaat;
            MskKalkisTarihi.Text = aktifUcakSefer.UcakKalkisTarih;
            mskBiletFiyati.Text = aktifUcakSefer.UcakSeferUcret.ToString();


        }

        private void btnSeferGuncelleIslem_Click(object sender, EventArgs e)
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
                { MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                else if (YardimciSinif.stringKontrol(ucakSefer.UcakNeredenYer, ucakSefer.UcakNereyeYer) == false)
                {
                    MessageBox.Show("**Yazi girilmesi gereken bilgiler rakam içermemeli.**", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    ucakSefer.UcakSeferUcret = int.Parse(mskBiletFiyati.Text);
                    con.Open();
                    SQLiteCommand komutGuncelle = new SQLiteCommand("update UcakSefer set UcakNeredenYer=@p1,UcakNereyeYer=@p2,UcakKalkisTarih=@p3,UcakKalkisSaat=@p4,UcakVarisSaat=@p5,UcakSeferUcret=@p6 where UcakNeredenYer=@p7 and UcakNereyeYer=@p8 and UcakKalkisTarih=@p9 and UcakKalkisSaat=@p10 and UcakVarisSaat=@p11 and UcakSeferUcret=@p12",con);
                    komutGuncelle.Parameters.AddWithValue("@p1", ucakSefer.UcakNeredenYer);
                    komutGuncelle.Parameters.AddWithValue("@p2", ucakSefer.UcakNereyeYer);
                    komutGuncelle.Parameters.AddWithValue("@p3", ucakSefer.UcakKalkisTarih);
                    komutGuncelle.Parameters.AddWithValue("@p4", ucakSefer.UcakKalkisSaat);
                    komutGuncelle.Parameters.AddWithValue("@p5", ucakSefer.UcakVarisSaat);
                    komutGuncelle.Parameters.AddWithValue("@p6", ucakSefer.UcakSeferUcret);
                    komutGuncelle.Parameters.AddWithValue("@p7", aktifUcakSefer.UcakNeredenYer);
                    komutGuncelle.Parameters.AddWithValue("@p8", aktifUcakSefer.UcakNereyeYer);
                    komutGuncelle.Parameters.AddWithValue("@p9", aktifUcakSefer.UcakKalkisTarih);
                    komutGuncelle.Parameters.AddWithValue("@p10", aktifUcakSefer.UcakKalkisSaat);
                    komutGuncelle.Parameters.AddWithValue("@p11", aktifUcakSefer.UcakVarisSaat);
                    komutGuncelle.Parameters.AddWithValue("@p12", aktifUcakSefer.UcakSeferUcret);

                    komutGuncelle.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Sefer Güncelleme islemi gerceklestirildi..", "Sefer Güncelleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    Application.OpenForms["AdminUcakSeferGuncelle"].Close();

                    con.Close();

                }
            }
            else
            {
                MessageBox.Show("Değerler BOŞ GEÇİLEMEZ", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
