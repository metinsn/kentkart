using System.Windows.Forms;

namespace kentkart
{
    class OgretmenKart : kart
    {
        public override void Okut()
        {
            MessageBox.Show("1 TL Alındı. Kalan Bakiye :" + (bakiye - 2));
            bakiye -= 2;
        }
    }
}
