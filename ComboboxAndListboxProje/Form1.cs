using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxAndListboxProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text + " " + textBox1.Text + " " + textBox3.Text + " " + textBox4.Text + " " + textBox5.Text);
            label6.Text = textBox2.Text;
            label7.Text = textBox1.Text;
            label8.Text = textBox3.Text;
            label9.Text = textBox4.Text;
            label10.Text = textBox5.Text;
        }
    }
}
