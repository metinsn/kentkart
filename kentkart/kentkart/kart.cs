﻿using System.Windows.Forms;

namespace kentkart
{
    enum YolcuTipi
    {
        Tam,
        Ogrenci,
        Ogretmen
    }
    class kart
    {
        public int kartid { get; set; }
        public double _bakiye;
        public double bakiye
        {
            get
            {
                return _bakiye;
            }
            set
            {
                _bakiye = value;
            }
        }
        public YolcuTipi kartturu { get; set; }

        public virtual void Okut()
        {
            MessageBox.Show("Biniş Başarılı! Kalan Bakiye :" + (bakiye - 3));
        }

        public override string ToString()
        {
            return base.ToString();
            {
                return kartid + "\t" + bakiye + "\t" + kartturu;
            }
        }

    }
    }
