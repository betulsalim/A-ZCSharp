using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathematicFunctions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Abs(number).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Ceiling(number).ToString();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Floor(number).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Pow(number, 2).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Sqrt(number).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
          //  double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.PI.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Cos(number).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            label2.Text = Math.Sin(number).ToString();
        }
    }
}
/*
 * Abs = mutlak değer
 * Ceil = üste yuvarlama
 * Floor = Alta yuvarlama
 * Pow = üs alma
 */