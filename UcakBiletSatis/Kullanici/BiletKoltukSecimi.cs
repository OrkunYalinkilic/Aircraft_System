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
    public partial class BiletKoltukSecimi : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        Button button;
        Button aktifButton = new Button();

        Kullanici aktifKullanici;
        UcakSefer aktifUcakSefer;
        List<UcakSeferKoltuk> SeferKoltukList = new List<UcakSeferKoltuk>();
        UcakSeferKoltuk aktifUcakSeferKoltuk = new UcakSeferKoltuk();
        public BiletKoltukSecimi(UcakSefer _aktifUcakSefer, Kullanici _aktifKullanici)
        {
            aktifUcakSefer = _aktifUcakSefer;
            aktifKullanici = _aktifKullanici;

            InitializeComponent();
        }

        private void BiletKoltukSecimi_Load(object sender, EventArgs e)
        {
            con.Open();
            SQLiteCommand komut = new SQLiteCommand("select *from UcakKoltukDurum where UcakSeferID=@p1", con);
            komut.Parameters.AddWithValue("@p1", aktifUcakSefer.UcakSeferID);
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SeferKoltukList.Add(new UcakSeferKoltuk(
                    int.Parse(oku[0].ToString()),
                    int.Parse(oku[1].ToString()),
                    bool.Parse(oku[2].ToString()),
                    int.Parse(oku[3].ToString())
                    ));
            }
            con.Close();

            for (int i = 0; i < SeferKoltukList.Count; i++)
            {
                button = new Button();

                button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                button.ForeColor = System.Drawing.Color.Transparent;
                button.Location = new System.Drawing.Point(343, 135);
                button.Margin = new System.Windows.Forms.Padding(4);
                button.Name = "btnKoltuk" + SeferKoltukList[i].koltukNumara.ToString();
                button.Size = new System.Drawing.Size(120, 52);
                button.Size = new System.Drawing.Size(120, 52);
                // button.TabIndex = 141;
                button.Text = SeferKoltukList[i].koltukNumara.ToString();
                button.UseVisualStyleBackColor = false;
                button.Tag = SeferKoltukList[i];

                if (SeferKoltukList[i].koltukDurum == false) { button.BackColor = System.Drawing.Color.Blue; }
                else
                {
                    button.BackColor = System.Drawing.Color.Red;
                    button.Enabled = false;
                }

                UcakSeferKoltuk aktifKoltuk = SeferKoltukList[i];

                button.Click += new EventHandler(button_Click);

                flowLayoutPanelKoltuklar.Controls.Add(button);

            }

            labelSeferBilgi.Text = aktifUcakSefer.UcakKalkisTarih + " " +
                aktifUcakSefer.UcakKalkisSaat + " " + aktifUcakSefer.UcakNeredenYer + " - " +
                aktifUcakSefer.UcakNereyeYer;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            aktifUcakSeferKoltuk = (UcakSeferKoltuk)b.Tag;

            if (b.BackColor == System.Drawing.Color.Blue)
            {
                aktifButton.BackColor = System.Drawing.Color.Blue;
                aktifButton = b;
                b.BackColor = System.Drawing.Color.DarkBlue;
            }
        }

        private void btnKoltukSecimTamamla_Click(object sender, EventArgs e)
        {
            // Fatura Bilgisi

            BiletOnayFatura frm = new BiletOnayFatura(aktifKullanici, aktifUcakSefer, aktifUcakSeferKoltuk);
            frm.ShowDialog();


        }
    }
}
