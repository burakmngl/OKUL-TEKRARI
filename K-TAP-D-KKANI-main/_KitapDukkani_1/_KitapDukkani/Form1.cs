using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _KitapDukkani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Yazar> Yazarlar = new List<Yazar>();   
        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            Yazar yzr = new Yazar();
            yzr.YazarAdı = txtYazarAdi.Text;
            yzr.YazarDogumTarihi = dtYazarDogumTarihi.Value;
            if (chkNobel.Checked==true)
            {
                yzr.NobelÖdülü = true;
            }
            else
            {
                yzr.NobelÖdülü = false;
            }
            Yazarlar.Add(yzr);
            cmbYazar.Items.Add(yzr);
            cmbYazar.DisplayMember="YazarAdı";
        
        }
        List<Kitap> Kitaplar = new List<Kitap>();
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Kitap ktp = new Kitap();
            ktp.KitapAdı = txtKitapAdi.Text;
            ktp.KitapTürü = (string)cmbKitapTuru.SelectedItem;
            ktp.SayfaSayısı = int.Parse(txtSayfaSayisi.Text);
            ktp.KitapFiyatı = int.Parse(txtFiyat.Text);
            ktp.Yazarı = (Yazar)this.cmbYazar.SelectedItem;
            Kitaplar.Add(ktp);
            cmbKitap.Items.Add(ktp);
            cmbKitap.DisplayMember = "KitapAdı";
            
        }
        List<Müşteri> müsteriler = new List<Müşteri>();
        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Müşteri mşt = new Müşteri();
            mşt.MüşteriAdı = txtMusteriAdi.Text;
            mşt.MüşteriMesleği = txtMeslegi.Text;
            mşt.kitapAd = (Kitap)this.cmbKitap.SelectedItem;
            mşt.MüşteriYaşı =txtMusteriYas.Text;
            müsteriler.Add(mşt);
           
            
        }

        private void btnMusterileriGetir_Click(object sender, EventArgs e)
        {
            lsbMusteriler.Items.Clear();
            foreach (Müşteri x in müsteriler)
            {
                lsbMusteriler.Items.Add(x.MüşteriAdı + " " + x.kitapAd.KitapAdı + " " + x.MüşteriMesleği + " " + x.MüşteriYaşı);
            }
        }
    }
}
