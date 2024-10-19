using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam;

            sayi1 = 5;
            sayi2 = 4;
            toplam = sayi1 + sayi2;

            label1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, alan, cevre;

            kisaKenar = 10;
            uzunKenar = 15;
            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);

            label6.Text = kisaKenar.ToString();
            label7.Text = uzunKenar.ToString();
            label8.Text = alan.ToString();
            label9.Text = cevre.ToString();
            label10.Text = "Alan: " + alan + " Çevre: " + cevre;

        }
    }
}
