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
    public partial class DataTestForm : Form
    {
        public DataTestForm()
        {
            InitializeComponent();
        }

        private void DataTestForm_Load(object sender, EventArgs e)
        {
            #region

            /* // Kullanıcı Tablosu Ekleme

             string komutKullaniciTable = "CREATE TABLE Kullanici(KullaniciID   INTEGER NOT NULL UNIQUE,Adi   TEXT,Soyadi    TEXT,TcKimlikNumarasi  TEXT,CepNumarasi   TEXT,KullaniciAdi  TEXT,Sifre TEXT,PRIMARY KEY(KullaniciID AUTOINCREMENT))";
             SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
             SQLiteCommand com = new SQLiteCommand(komutKullaniciTable, con);
             con.Open();

             con.Clone();
             con.Close();

             // Bilet Tablosu Ekleme

             string komutBiletTable = "CREATE TABLE Bilet(BiletID  INTEGER,KullaniciID  INTEGER,UcakSeferID  INTEGER,KoltukNumarasi   INTEGER,PRIMARY KEY(BiletID AUTOINCREMENT))";
             SQLiteCommand comBiletTable = new SQLiteCommand(komutBiletTable, con);
             con.Open();

             con.Clone();
             con.Close();

             // UcakKoltukDurum Tablosu Ekleme

             string komutUcakKoltukDurumTable = "CREATE TABLE UcakKoltukDurum(UcakSeferID  INTEGER,KoltukNo  INTEGER,KoltukDurum  INTEGER,KoltukSahibiID  INTEGER)";
             SQLiteCommand comUcakKoltukDurumTable = new SQLiteCommand(komutUcakKoltukDurumTable, con);
             con.Open();

             con.Clone();
             con.Close();

             // UcakSefer Tablosu Ekleme

             string komutUcakSeferTable = "CREATE TABLE UcakSefer(UcakSeferID INTEGER NOT NULL,UcakNeredenYer TEXT,UcakNereyeYer TEXT,UcakKalkisSaat    TEXT,UcakVarisSaat TEXT,UcakKalkisTarih   TEXT,UcakSeferUcret    INTEGER,PRIMARY KEY(UcakSeferID AUTOINCREMENT))";
             SQLiteCommand comUcakSeferTable = new SQLiteCommand(komutUcakSeferTable, con);
             con.Open();

             con.Clone();
             con.Close();*/

            #endregion

            #region
            /*
            // Kullanici Tablosu Kaldırma

            string komutKullaniciTable = "drop table Kullanici ";
            SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
            SQLiteCommand com = new SQLiteCommand(komutKullaniciTable, con);
            con.Open();

            con.Clone();
            con.Close();

            // Bilet Tablosu Kaldırma

            string komutBiletTable = "drop table Bilet ";
            SQLiteCommand comBiletTable = new SQLiteCommand(komutBiletTable, con);
            con.Open();

            con.Clone();
            con.Close();

            // UcakKoltukDurum Tablosu Kaldırma

            string komutUcakKoltukDurumTable = "drop table UcakKoltukDurum ";
            SQLiteCommand comUcakKoltukDurumTable = new SQLiteCommand(komutUcakKoltukDurumTable, con);
            con.Open();

            con.Clone();
            con.Close();

            // UcakSefer Tablosu Kaldırma

            string komutUcakSeferTable = "drop table UcakSefer ";
            SQLiteCommand comUcakSeferTable = new SQLiteCommand(komutUcakSeferTable, con);
            con.Open();

            con.Clone();
            con.Close();
*/
            #endregion
          
            #region 
           /* string komut2 = "INSERT INTO Kullanici(Adi, Soyadi, TcKimlikNumarasi,CepNumarasi,KullaniciAdi,Sifre) VALUES('Orkun', 'GÜRSOY', '23421', '3421', 'test', 'acaba'); ";

            //string komut2 = "Delete from Kullanici";

            SQLiteConnection con2 = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
            SQLiteCommand com2 = new SQLiteCommand(komut2, con2);
            con2.Open();

            com2.ExecuteNonQuery();

            con2.Clone();*/

            #endregion

            #region
            /* SQLiteConnection con3 = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
             SQLiteCommand com3 = new SQLiteCommand("select * from Kullanici", con3);
             con3.Open();

             SQLiteDataReader rdr = com3.ExecuteReader();

             while (rdr.Read())
             {
                 rchTextBox.AppendText(rdr["Adi"].ToString() + rdr["Soyadi"].ToString() + " ");
             }

             rdr.Close();

             con3.Clone();

             con3.Close();*/
            #endregion

            Login frm = new Login();
            frm.ShowDialog();

           // Application.OpenForms[1].Close();



        }
    }
}
