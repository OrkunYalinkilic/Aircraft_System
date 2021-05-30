using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletSatis.Models__Class_
{
    public class LoginTuruDisplay : ILoginTuru
    {
        public void LogIn(Kullanici kullanici)
        {
            kullanici.LogIn(kullanici);
        }

        public void LogIn(Yonetici kullanici)
        {
            Admin frm = new Admin();
            frm.ShowDialog();
        }
    }
}



