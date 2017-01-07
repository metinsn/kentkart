namespace kentkart
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpboxKartOlustur = new System.Windows.Forms.GroupBox();
            this.rbtnTam = new System.Windows.Forms.RadioButton();
            this.rbtnOgrenci = new System.Windows.Forms.RadioButton();
            this.rbtnOgretmen = new System.Windows.Forms.RadioButton();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.grpboxOkulAdi = new System.Windows.Forms.GroupBox();
            this.txtboxOkulAdi = new System.Windows.Forms.TextBox();
            this.lstBoxYolcular = new System.Windows.Forms.ListBox();
            this.grpboxKartOlustur.SuspendLayout();
            this.grpboxOkulAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxKartOlustur
            // 
            this.grpboxKartOlustur.Controls.Add(this.grpboxOkulAdi);
            this.grpboxKartOlustur.Controls.Add(this.btnEkle);
            this.grpboxKartOlustur.Controls.Add(this.txtBakiye);
            this.grpboxKartOlustur.Controls.Add(this.lblBakiye);
            this.grpboxKartOlustur.Controls.Add(this.rbtnOgretmen);
            this.grpboxKartOlustur.Controls.Add(this.rbtnOgrenci);
            this.grpboxKartOlustur.Controls.Add(this.rbtnTam);
            this.grpboxKartOlustur.Location = new System.Drawing.Point(0, 0);
            this.grpboxKartOlustur.Name = "grpboxKartOlustur";
            this.grpboxKartOlustur.Size = new System.Drawing.Size(269, 125);
            this.grpboxKartOlustur.TabIndex = 0;
            this.grpboxKartOlustur.TabStop = false;
            this.grpboxKartOlustur.Text = "Kart Oluştur";
            // 
            // rbtnTam
            // 
            this.rbtnTam.AutoSize = true;
            this.rbtnTam.Checked = true;
            this.rbtnTam.Location = new System.Drawing.Point(12, 17);
            this.rbtnTam.Name = "rbtnTam";
            this.rbtnTam.Size = new System.Drawing.Size(46, 17);
            this.rbtnTam.TabIndex = 0;
            this.rbtnTam.TabStop = true;
            this.rbtnTam.Text = "Tam";
            this.rbtnTam.UseVisualStyleBackColor = true;
            // 
            // rbtnOgrenci
            // 
            this.rbtnOgrenci.AutoSize = true;
            this.rbtnOgrenci.Location = new System.Drawing.Point(12, 40);
            this.rbtnOgrenci.Name = "rbtnOgrenci";
            this.rbtnOgrenci.Size = new System.Drawing.Size(62, 17);
            this.rbtnOgrenci.TabIndex = 1;
            this.rbtnOgrenci.TabStop = true;
            this.rbtnOgrenci.Text = "Öğrenci";
            this.rbtnOgrenci.UseVisualStyleBackColor = true;
            this.rbtnOgrenci.CheckedChanged += new System.EventHandler(this.rbtnOgrenci_CheckedChanged);
            // 
            // rbtnOgretmen
            // 
            this.rbtnOgretmen.AutoSize = true;
            this.rbtnOgretmen.Location = new System.Drawing.Point(12, 63);
            this.rbtnOgretmen.Name = "rbtnOgretmen";
            this.rbtnOgretmen.Size = new System.Drawing.Size(71, 17);
            this.rbtnOgretmen.TabIndex = 2;
            this.rbtnOgretmen.Text = "Öğretmen";
            this.rbtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(111, 21);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(39, 13);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "Bakiye";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(114, 37);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEkle.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnEkle.Location = new System.Drawing.Point(12, 86);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 33);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // grpboxOkulAdi
            // 
            this.grpboxOkulAdi.Controls.Add(this.txtboxOkulAdi);
            this.grpboxOkulAdi.Location = new System.Drawing.Point(93, 65);
            this.grpboxOkulAdi.Name = "grpboxOkulAdi";
            this.grpboxOkulAdi.Size = new System.Drawing.Size(161, 54);
            this.grpboxOkulAdi.TabIndex = 5;
            this.grpboxOkulAdi.TabStop = false;
            this.grpboxOkulAdi.Text = "Okul Adı";
            // 
            // txtboxOkulAdi
            // 
            this.txtboxOkulAdi.Location = new System.Drawing.Point(19, 23);
            this.txtboxOkulAdi.Name = "txtboxOkulAdi";
            this.txtboxOkulAdi.Size = new System.Drawing.Size(136, 20);
            this.txtboxOkulAdi.TabIndex = 4;
            // 
            // lstBoxYolcular
            // 
            this.lstBoxYolcular.FormattingEnabled = true;
            this.lstBoxYolcular.Location = new System.Drawing.Point(12, 131);
            this.lstBoxYolcular.Name = "lstBoxYolcular";
            this.lstBoxYolcular.Size = new System.Drawing.Size(257, 95);
            this.lstBoxYolcular.TabIndex = 1;
            this.lstBoxYolcular.Tag = "";
            this.lstBoxYolcular.DoubleClick += new System.EventHandler(this.lstBoxYolcular_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 243);
            this.Controls.Add(this.lstBoxYolcular);
            this.Controls.Add(this.grpboxKartOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxKartOlustur.ResumeLayout(false);
            this.grpboxKartOlustur.PerformLayout();
            this.grpboxOkulAdi.ResumeLayout(false);
            this.grpboxOkulAdi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxKartOlustur;
        private System.Windows.Forms.RadioButton rbtnOgretmen;
        private System.Windows.Forms.RadioButton rbtnOgrenci;
        private System.Windows.Forms.RadioButton rbtnTam;
        private System.Windows.Forms.GroupBox grpboxOkulAdi;
        private System.Windows.Forms.TextBox txtboxOkulAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.ListBox lstBoxYolcular;
    }
}

