using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DikdortgenAlanCevreProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisaKenar = 10, uzunKenar = 20, alan, cevre;
            alan = kisaKenar * uzunKenar;
            cevre = 2 * (kisaKenar + uzunKenar);

            label5.Text = uzunKenar.ToString();
            label6.Text = kisaKenar.ToString();
            label7.Text = alan.ToString();
            label8.Text = cevre.ToString();
            label9.Text = "Alan: " + alan + " Çevre: " + cevre;
        }
    }
}
