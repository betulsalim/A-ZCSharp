using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleDegiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double sayi;
            //sayi = 4.25;
            //label1.Text = sayi.ToString();
            double sinavNotu1, sinavNotu2, sinavNotu3, ortalama;
            sinavNotu1 = Convert.ToDouble(textBox1.Text);
            sinavNotu2 = Convert.ToDouble(textBox2.Text);
            sinavNotu3 = Convert.ToDouble(textBox3.Text);
            ortalama = (sinavNotu1 + sinavNotu2 + sinavNotu3) / 3;
            label4.Text = sinavNotu1.ToString();
            label5.Text = sinavNotu2.ToString();
            label6.Text = sinavNotu3.ToString();
            label8.Text = ortalama.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
