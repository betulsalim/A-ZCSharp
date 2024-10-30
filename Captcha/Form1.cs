using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] symbol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] symbol2 = { "+", "-", "*", "/" , "#"};
            int symbol3;

            Random random = new Random();
            int s1, s2;
            s1 = random.Next(0, symbol1.Length);
            s2 = random.Next(0, symbol2.Length);
            symbol3 = random.Next(0, 5);

            label1.Text = symbol1[s1].ToString() + symbol2[s2].ToString() + symbol3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            //form2 gelsin form1 i sakla
        }
    }
}
