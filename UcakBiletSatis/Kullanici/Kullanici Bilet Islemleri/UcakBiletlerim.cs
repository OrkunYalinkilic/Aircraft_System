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
using System.Data.SQLite;

namespace UcakBiletSatis
{
    public partial class UcakBiletlerim : Form
    {
        Kullanici aktifKullanici;
        Label labelBilet;
        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
        List<Bilet> kullaniciBiletleri = new List<Bilet>();

        public Bilet gelenBilet = new Bilet();

        public UcakBiletlerim(Kullanici _aktifKullanici)
        {
            aktifKullanici = _aktifKullanici;
            InitializeComponent();
        }

        private void UcakBiletlerim_Load(object sender, EventArgs e)
        {
            con.Open();
            SQLiteCommand komut = new SQLiteCommand("select UcakNeredenYer,UcakNereyeYer,UcakKalkisTarih,UcakKalkisSaat,UcakVarisSaat,KoltukNumarasi from Bilet inner join UcakSefer on Bilet.UcakSeferID=UcakSefer.UcakSeferID where KullaniciID=@p1", con);
            komut.Parameters.AddWithValue("@p1", aktifKullanici.kullaniciID);
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
              // Klonlama işlemini fiili olarak burada kullandım.
                 //Prototip Desen kullandığım alandır. Açıklama kısmında açıkladım.

                 Bilet yeniGelenBilet = gelenBilet.getClone();

                yeniGelenBilet.hareketYeri = oku[0].ToString();
                yeniGelenBilet.varisYeri = oku[1].ToString();
                yeniGelenBilet.kalkisTarih = oku[2].ToString();
                yeniGelenBilet.kalkisSaat = oku[3].ToString();
                yeniGelenBilet.varisSaat = oku[4].ToString();
                yeniGelenBilet.koltukNumarasi = oku[5].ToString();

                kullaniciBiletleri.Add(yeniGelenBilet);
            }
            con.Close();

            for(int i=0; i<kullaniciBiletleri.Count; i++)
            {
                labelBilet = new Label();

                labelBilet.AutoSize = true;
                labelBilet.BackColor = System.Drawing.SystemColors.HighlightText;
                labelBilet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelBilet.Location = new System.Drawing.Point(55, 50);
                labelBilet.Name = "label";
                labelBilet.Size = new System.Drawing.Size(192, 24);
                labelBilet.TabIndex = 0;
                labelBilet.Padding = new System.Windows.Forms.Padding(10);
                labelBilet.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);

                labelBilet.Text = "Hareket Yeri: " + kullaniciBiletleri[i].hareketYeri + "\n" +
                 "Varış Yeri: " + kullaniciBiletleri[i].varisYeri +"\n" +
                 "Kalkış Tarihi: " + kullaniciBiletleri[i].kalkisTarih + "\n" +
                 "Kalkış Saati:" + kullaniciBiletleri[i].kalkisSaat + "\n" +
                 "Varış Saati: " + kullaniciBiletleri[i].varisSaat + "\n" +
                 "Koltuk Numarası: " + kullaniciBiletleri[i].koltukNumarasi + "\n";

                flowLayoutPanelBiletlerim.Controls.Add(labelBilet);

            }

          
        }

        private void flowLayoutPanelBiletlerim_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
