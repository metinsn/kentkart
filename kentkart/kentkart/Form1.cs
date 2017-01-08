using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kentkart
{
    public partial class Form1 : Form
    {
        public Form1(kart yolcu)
        {
            InitializeComponent();
        }
        OgrenciKart ogrenci = new OgrenciKart();
        OgretmenKart ogretmen = new OgretmenKart();
        kart tam = new kart();
        int kartid = 1;
        static List<kart> kalıcıliste= new List<kart>();
        

        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (rbtnOgrenci.Checked)
            {
                ogrenci.bakiye = Convert.ToDouble(txtBakiye.Text);
                ogrenci.kartid = kartid;
                kartid++;
                ogrenci.okuladi = txtboxOkulAdi.Text;
                ogrenci.kartturu = YolcuTipi.Ogrenci;
                lstBoxYolcular.Items.Add(ogrenci);
                kalıcıliste.Add(ogrenci);
            }
            else if (rbtnOgretmen.Checked)
            {
                ogretmen.bakiye = Convert.ToDouble(txtBakiye.Text);
                ogretmen.kartid = kartid;
                kartid++;
                ogretmen.kartturu = YolcuTipi.Ogretmen;
                lstBoxYolcular.Items.Add(ogretmen);
                kalıcıliste.Add(ogretmen);
            }
            else if (rbtnTam.Checked)
            {
                tam.bakiye = Convert.ToDouble(txtBakiye.Text);
                tam.kartid = kartid;
                kartid++;
                tam.kartturu = YolcuTipi.Tam;
                lstBoxYolcular.Items.Add(tam);
                kalıcıliste.Add(tam);
            }
            Temizle();
        }

        private void rbtnOgrenci_CheckedChanged(object sender, EventArgs e)
        {
            txtboxOkulAdi.Enabled = rbtnOgrenci.Checked == true ? true : false;
        }

        public void Temizle()
        {
            txtBakiye.Clear();
            txtboxOkulAdi.Clear();

        }

        private void lstBoxYolcular_DoubleClick(object sender, EventArgs e)
        {
            //var yolcu = lstBoxYolcular.SelectedItem;
            kart yolcu = (kart)lstBoxYolcular.SelectedItem;

            if (yolcu.kartturu == YolcuTipi.Ogrenci && yolcu.bakiye - 1 >= 0)
            {
                lstBoxYolcular.Items.RemoveAt(lstBoxYolcular.SelectedIndex);
                ogrenci = (OgrenciKart)yolcu;
                ogrenci.Okut();
                lstBoxYolcular.Items.Add(ogrenci);
            }
            else if (yolcu.kartturu == YolcuTipi.Ogretmen && yolcu.bakiye - 2 >= 0)
            {
                lstBoxYolcular.Items.RemoveAt(lstBoxYolcular.SelectedIndex);
                ogretmen = (OgretmenKart)yolcu;
                ogretmen.Okut();
                lstBoxYolcular.Items.Add(ogretmen);
            }
            else if (yolcu.kartturu == YolcuTipi.Tam && yolcu.bakiye -3 >= 0)
            {
                lstBoxYolcular.Items.RemoveAt(lstBoxYolcular.SelectedIndex);
                tam = yolcu;
                tam.Okut();
                lstBoxYolcular.Items.Add(tam);
            }
            else
            {
                MessageBox.Show("Yetersiz Bakiye ! ");
                DialogResult result = MessageBox.Show("Bakiye Yüklemek İstermisiniz ?", "Bildirim Ekranı",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form2 form2 = new Form2(yolcu);
                    form2.Show();
                    this.Hide();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in kalıcıliste)
            {
                lstBoxYolcular.Items.Add(item);
            }
        }
    }
}
