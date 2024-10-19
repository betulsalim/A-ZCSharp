using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrtalamaHesaplamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int not1 = 50, not2 = 45, not3 = 75, ortalama;

            ortalama = (not1 + not2 + not3) / 3;
            label4.Text = not1.ToString();
            label5.Text = not2.ToString();
            label6.Text = not3.ToString();
            label7.Text = "Not Ortalaması: " + ortalama;
        }
    }
}
