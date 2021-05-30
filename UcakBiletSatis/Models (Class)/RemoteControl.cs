using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletSatis.Models__Class_
{
    public class RemoteControl
    {
        UcakSeferOnayli seferOnay;
        UcakSeferRed seferRed;
        public void setDebugMessageOnay(UcakSeferOnayli seferOnay)
        {
            this.seferOnay = seferOnay;
        }

        public void setDebugMessageRed(UcakSeferRed seferRed)
        {
            this.seferRed = seferRed;
        }

        public void remoteExecute() {
            Debug.WriteLine("Remote Control Calisti.");
        }
    }
}
