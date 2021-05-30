using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcakBiletSatis.Models__Class_
{
    public class UcakSeferOnayli : UcakSefer
    {
        public UcakSefer ucakSefer;
        public void OnayMesajBildir()
        {
            MessageBox.Show("Biletiniz Onaylanmıştır.\n Biletlerim menüsünden bilet ayrıntılarınızı kontrol edebilirsiniz.",
                "Bilet Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public UcakSeferOnayli()
        {
        }

        public UcakSeferOnayli(UcakSefer _ucakSefer)
        {
            this.ucakSefer = _ucakSefer;
            UcakSeferBiletOnaylandi();
        }

        public void UcakSeferBiletOnaylandi()
        {
            Debug.WriteLine("Ucak Bileti Onaylandi");
        }

    }
}
