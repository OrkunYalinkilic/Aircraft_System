using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcakBiletSatis.Models__Class_;

namespace UcakBiletSatis
{
    public class Bilet 
    {
        public string hareketYeri { get; set; }
        public string varisYeri { get; set; }
        public string kalkisTarih { get; set; }
        public string kalkisSaat { get; set; }
        public string varisSaat { get; set; }
        public string koltukNumarasi { get; set; }

        public Bilet()
        {
        }

        public Bilet(string hareketYeri, string varisYeri, string kalkisTarih, string kalkisSaat, string varisSaat, string koltukNumarasi)
        {
            this.hareketYeri = hareketYeri;
            this.varisYeri = varisYeri;
            this.kalkisTarih = kalkisTarih;
            this.kalkisSaat = kalkisSaat;
            this.varisSaat = varisSaat;
            this.koltukNumarasi = koltukNumarasi;

        }

      
    }
}
