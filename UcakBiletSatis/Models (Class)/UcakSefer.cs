using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletSatis
{
    public class UcakSefer
    {
        public int UcakSeferID { get; set; }
        public string UcakNeredenYer { get; set; }
        public string UcakNereyeYer { get; set; }
        public string UcakKalkisSaat { get; set; }
        public string UcakVarisSaat { get; set; }
        public string UcakKalkisTarih { get; set; }
        public int UcakSeferUcret { get; set; }


        public bool boslukKontrol()
        {
            if (string.IsNullOrEmpty(UcakNeredenYer) == true ||
                string.IsNullOrEmpty(UcakNereyeYer) == true ||
                string.IsNullOrEmpty(UcakKalkisSaat) == true ||
                string.IsNullOrEmpty(UcakVarisSaat) == true ||
                string.IsNullOrEmpty(UcakKalkisTarih) == true ||
                string.IsNullOrEmpty(UcakSeferUcret.ToString()) == true)
            {
                return false;
            }

            return true;
        }




    }
}
