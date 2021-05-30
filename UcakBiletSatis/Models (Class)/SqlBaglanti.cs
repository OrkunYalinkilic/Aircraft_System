using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace UcakBiletSatis
{
    class SqlBaglanti
    {
          public SQLiteConnection baglanti()
        {
            //   SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=DbUcakBiletSatis;Integrated Security=True");


                 SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");
            con.Open();
            return con;

        }
    }
}
