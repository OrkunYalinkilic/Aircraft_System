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
    public partial class AdminSeferSilOnay : Form
    {
        //  SqlBaglanti bgl = new SqlBaglanti();

        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        UcakSefer aktifUcakSefer;
        public AdminSeferSilOnay(UcakSefer _aktifUcakSefer)
        {
            aktifUcakSefer = _aktifUcakSefer;
            InitializeComponent();
        }

        private void AdminSeferSilOnay_Load(object sender, EventArgs e)
        {
            labelBiletHareketYer.Text = aktifUcakSefer.UcakNeredenYer;
            labelBiletVarisYer.Text = aktifUcakSefer.UcakNereyeYer;
            labelBiletKalkisSaat.Text = aktifUcakSefer.UcakKalkisSaat;
            labelBiletVarisSaat.Text = aktifUcakSefer.UcakVarisSaat;
            labelBiletKalkisTarih.Text = aktifUcakSefer.UcakKalkisTarih;
            labelBiletFiyati.Text = aktifUcakSefer.UcakSeferUcret.ToString();
        }

        private void btnSeferSilEvet_Click(object sender, EventArgs e)
        {
            con.Open();
            SQLiteCommand komutSil = new SQLiteCommand(" delete from UcakSefer where UcakNeredenYer=@p1 and UcakNereyeYer=@p2 and UcakKalkisTarih=@p3 and UcakKalkisSaat=@p4 and UcakVarisSaat=@p5 and UcakSeferUcret=@p6", con);
            komutSil.Parameters.AddWithValue("@p1",aktifUcakSefer.UcakNeredenYer );
            komutSil.Parameters.AddWithValue("@p2",aktifUcakSefer.UcakNereyeYer );
            komutSil.Parameters.AddWithValue("@p3", aktifUcakSefer.UcakKalkisTarih);
            komutSil.Parameters.AddWithValue("@p4", aktifUcakSefer.UcakKalkisSaat);
            komutSil.Parameters.AddWithValue("@p5", aktifUcakSefer.UcakVarisSaat);
            komutSil.Parameters.AddWithValue("@p6", aktifUcakSefer.UcakSeferUcret);

            komutSil.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Oda Silme İşlemi Gerçekleştirildi", "Oda Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Application.OpenForms["AdminSeferSilOnay"].Close();
            Application.OpenForms["AdminUcakSeferSil"].Close();

        }

        private void btnSeferSilHayır_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AdminSeferSilOnay"].Close();
        }
    }
}
