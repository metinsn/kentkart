﻿using System;
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
    public partial class Form2 : Form
    {
        kart gelenyolcu = new kart();
        public Form2(kart yolcu)
        {
            InitializeComponent();
            gelenyolcu = yolcu;
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            gelenyolcu.bakiye += Convert.ToDouble(txtyuklememiktari.Text);

            Form1 frm = new kentkart.Form1(gelenyolcu);
            frm.ShowDialog();
            this.Hide();
        }
    }
}
