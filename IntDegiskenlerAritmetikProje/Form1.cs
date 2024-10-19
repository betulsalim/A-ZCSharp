using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntDegiskenlerAritmetikProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, toplam, cikarma, carpma, bolme;

            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);

            toplam = num1 + num2;
            cikarma = num1 - num2;
            carpma = num2 * num1;
            bolme = num1 / num2;

            label1.Text = num1.ToString();
            label3.Text = num2.ToString();
            label4.Text = num1.ToString();
            label6.Text = num2.ToString();
            label7.Text = num1.ToString();
            label9.Text = num2.ToString();
            label10.Text = num1.ToString();
            label12.Text = num2.ToString();

            label17.Text = toplam.ToString();
            label18.Text = cikarma.ToString();
            label19.Text = carpma.ToString();
            label20.Text = bolme.ToString();

            MessageBox.Show("Toplam: " + toplam + "\nFark: " + cikarma + "\nÇarpma: " + carpma + "\nBölme: " + bolme);

        }
    }
}
