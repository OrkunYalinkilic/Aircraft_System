using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace UcakBiletSatis
{
    class SqlBaglanti
    {
          public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=DbUcakBiletSatis;Integrated Security=True");
            baglan.Open();
            return baglan;

       //     SQLiteConnection con = new SQLiteConnection(@"Data Source=UcakBiletSatisDb.db");

        }
    }
}
