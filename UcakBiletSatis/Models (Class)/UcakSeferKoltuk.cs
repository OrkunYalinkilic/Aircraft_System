using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletSatis
{
    public class UcakSeferKoltuk
    {
        public int UcakSeferID { get; set; }
        public int koltukNumara { get; set; }
        public bool koltukDurum { get; set; }
        public int koltukSahibiID { get; set; }

        public UcakSeferKoltuk()
        {
        }

        public UcakSeferKoltuk(int ucakSeferID, int koltukNumara, bool koltukDurum, int koltukSahibiID)
        {
            UcakSeferID = ucakSeferID;
            this.koltukNumara = koltukNumara;
            this.koltukDurum = koltukDurum;
            this.koltukSahibiID = koltukSahibiID;
        }

    }
}
