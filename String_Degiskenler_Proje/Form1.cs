using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Degiskenler_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad, yas, meslek, cinsiyet;
            ad = textBox4.Text;
            soyad = textBox3.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox2.Text;
            cinsiyet = textBox1.Text;

            listBox1.Items.Add("Adınız: " + ad + " Soyadınız: " + soyad + " Yaşınız: " + yas + " Mesleğiniz: " + meslek + " Cinsiyetiniz: " + cinsiyet);
        }
    }
}
