using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Class_yapısı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Öğrenci> ÖğrenciListesi = new List<Öğrenci>();
         
        private void Button1_Click(object sender, EventArgs e)
        {
            Öğrenci ogr1 = new Öğrenci();
            ogr1.ad = txtAD.Text;
            ogr1.soyadı = txtSOYAD.Text;
            ogr1.numara = txtNO.Text;
            ÖğrenciListesi.Add(ogr1);
            ogr1.ekle();
            txtAD.Text = "";
            txtSOYAD.Text = "";
            txtNO.Text = "";

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            foreach (Öğrenci x in ÖğrenciListesi)
            {
                ListBox1.Items.Add(x.numara + " " + x.ad + " " + x.soyadı);
            }
            int eleman = 0;
            eleman = ÖğrenciListesi.Count();
            ListBox1.Items.Add("eleman sayısı " + eleman);
        }
    }
}
