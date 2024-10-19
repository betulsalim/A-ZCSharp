using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Degiskenler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad, meslek;

            adSoyad = "Betül Salim";
            meslek = "Öğrenci";

            label1.Text = adSoyad;
            label2.Text = meslek;

            string sehir;

            sehir = textBox1.Text;
            label3.Text = sehir;
        }
    }
}
