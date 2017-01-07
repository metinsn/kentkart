using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kentkart
{
    class OgrenciKart : kart
    {
        public string okuladi { get; set; }

        public override void Okut()
        {
            MessageBox.Show("1 TL Alındı. Kalan Bakiye :" + (bakiye - 1));
            bakiye -= 1;
        }

        public override string ToString()
        {
            return kartid + "\t" + bakiye + "\t" + okuladi;
        }
    }
}

