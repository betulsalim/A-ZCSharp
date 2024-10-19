using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Kullanimlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba Dünya!");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label4.Text = "Betül";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = "Betül";
            label8.Text = "Salim";
            label10.Text = "Öğrenci";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Yazılım Mühendisliği";
            label11.Text = textBox1.Text;
        }
    }
}
