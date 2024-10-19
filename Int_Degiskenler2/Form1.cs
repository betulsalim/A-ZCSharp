using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_Degiskenler2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int sayi;

            //sayi = Convert.ToInt32(textBox1.Text);
            //label2.Text = sayi.ToString();

            // textBoxa girilen sayının küpünü alan program
            int num1, kup;

            num1 = Convert.ToInt32(textBox1.Text);
            label2.Text = num1.ToString();
            kup = num1 * num1 * num1;
            label3.Text = kup.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
