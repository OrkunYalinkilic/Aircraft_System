using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletSatis.Models__Class_
{
    public class UcakSeferRed : UcakSefer
    {
        public UcakSefer ucakSefer;

        public void RedMesajBildir()
        {
            MessageBox.Show("Biletiniz Onaylanmamıştır.\n Bilet Al menüsünden yeni bilet alabilirsiniz.",
                "Bilet Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public UcakSeferRed()
        {
        }

        public UcakSeferRed(UcakSefer _ucakSefer)
        {
            this.ucakSefer = _ucakSefer;
            UcakSeferBiletReddedildi();
        }

        public void UcakSeferBiletReddedildi()
        {
            Debug.WriteLine("Ucak Bileti Reddedildi");
        }



    }
}
