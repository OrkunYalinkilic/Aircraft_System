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
    public partial class UcakBiletiAl : Form
    {
        Kullanici aktifKullanici;
        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
        string secilenNereye = "", secilenNereden = "", secilenGidisTarih = "", secilenKalkisSaat = "";
        UcakSefer aktifUcakSefer = new UcakSefer();
        public UcakBiletiAl(Kullanici _aktifKullanici)
        {
            aktifKullanici = _aktifKullanici;
            InitializeComponent();
        }

        private void UcakBiletiAl_Load(object sender, EventArgs e)
        {
            labelAd.Text = aktifKullanici.adi;
            labelSoyad.Text = aktifKullanici.soyadi;
            labelCepTelNo.Text = aktifKullanici.cepTelefonNumara;
            labelTckimlikNo.Text = aktifKullanici.tcKimlikNo;

            // select UcakNeredenYer from UcakSefer

            //List<string> ucakNeredenList = new List<string>();

            con.Open();
            SQLiteCommand komut = new SQLiteCommand("select UcakNeredenYer from UcakSefer", con);
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read()) // Okuma işlemi gerçekleştiği müddetçe
            {
                comboBoxNereden.Items.Add(oku[0].ToString());
            }
            con.Close();

            //for(int i=0; i<ucakNeredenList.Count;i++) comboBoxNereden.Items.Add(ucakNeredenList[i]);

            /*private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            //ComboBox'da seçilen değeri yakalama.
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            MessageBox.Show(comboBox1.SelectedText.ToString());
            
            //ComboBox'da seçilen değerin indeksini yakalama.
            MessageBox.Show(comboBox1.SelectedIndex.ToString());
            }
            */

        }

        private void comboBoxNereden_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenNereden = (string)comboBoxNereden.SelectedItem;
            comboBoxNereye.Enabled = true;
            con.Open();
            SQLiteCommand komut2 = new SQLiteCommand("select UcakNereyeYer from UcakSefer where UcakNeredenYer=@p1", con);
            komut2.Parameters.AddWithValue("@p1", secilenNereden);
            SQLiteDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comboBoxNereye.Items.Add(oku2[0].ToString());
            }
            con.Close();
            comboBoxNereden.Enabled = false;
        }

        private void comboBoxGidisTarihi_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenGidisTarih = (string)comboBoxGidisTarihi.SelectedItem;
            comboBoxSaat.Enabled = true;
            con.Open();
            SQLiteCommand komut3 = new SQLiteCommand("select UcakKalkisSaat from UcakSefer where UcakNeredenYer=@p1 and UcakNereyeYer=@p2 and UcakKalkisTarih=@p3", con);
            komut3.Parameters.AddWithValue("@p1", secilenNereden);
            komut3.Parameters.AddWithValue("@p2", secilenNereye);
            komut3.Parameters.AddWithValue("@p3", secilenGidisTarih);

            SQLiteDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                comboBoxSaat.Items.Add(oku3[0].ToString());
            }
            con.Close();
            comboBoxGidisTarihi.Enabled = false;
        }

        private void btnKoltukSecimi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(secilenNereye) || string.IsNullOrEmpty(secilenNereden) || string.IsNullOrEmpty(secilenGidisTarih) || string.IsNullOrEmpty(secilenKalkisSaat))
            {
                MessageBox.Show("Lütfen bilet bilgilerinizi eksiksiz biçimde seçiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BiletKoltukSecimi frm = new BiletKoltukSecimi(aktifUcakSefer, aktifKullanici);
                frm.ShowDialog();
            }

        }

        private void comboBoxSaat_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenKalkisSaat = (string)comboBoxSaat.SelectedItem;
            con.Open();
            SQLiteCommand komut4 = new SQLiteCommand("select *from UcakSefer where UcakNeredenYer=@p1 and UcakNereyeYer=@p2 and UcakKalkisTarih=@p3 and UcakKalkisSaat=@p4 ", con);
            komut4.Parameters.AddWithValue("@p1", secilenNereden);
            komut4.Parameters.AddWithValue("@p2", secilenNereye);
            komut4.Parameters.AddWithValue("@p3", secilenGidisTarih);
            komut4.Parameters.AddWithValue("@p4", secilenKalkisSaat);

            SQLiteDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                comboBoxGidisTarihi.Items.Add(oku4[0].ToString());
                aktifUcakSefer.UcakSeferID = int.Parse(oku4[0].ToString());
                aktifUcakSefer.UcakNeredenYer = oku4[1].ToString();
                aktifUcakSefer.UcakNereyeYer = oku4[2].ToString();
                aktifUcakSefer.UcakKalkisSaat = oku4[3].ToString();
                aktifUcakSefer.UcakVarisSaat = oku4[4].ToString();
                aktifUcakSefer.UcakKalkisTarih = oku4[5].ToString();
                aktifUcakSefer.UcakSeferUcret = int.Parse(oku4[6].ToString());

            }
            con.Close();
        }

        private void comboBoxNereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilenNereye = (string)comboBoxNereye.SelectedItem;
            comboBoxGidisTarihi.Enabled = true;
            con.Open();
            SQLiteCommand komut3 = new SQLiteCommand("select UcakKalkisTarih from UcakSefer where UcakNeredenYer=@p1 and UcakNereyeYer=@p2", con);
            komut3.Parameters.AddWithValue("@p1", secilenNereden);
            komut3.Parameters.AddWithValue("@p2", secilenNereye);

            SQLiteDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                comboBoxGidisTarihi.Items.Add(oku3[0].ToString());
            }
            con.Close();
            comboBoxNereye.Enabled = false;
        }
    }
}
