using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum cities { X,Adana, Adıyaman, Afyon, Ağrı, Amasya, Ankara, Antalya, Artvin, Aydın };
        private void button1_Click(object sender, EventArgs e)
        {
            int licensePlate = Convert.ToInt16(textBox1.Text); //textboxtan gelen değeri al
            cities cities;
            cities = (cities)licensePlate; //citiesin licensePlate. değeri
            label1.Text = cities.ToString();
            textBox1.Clear();
        }
    }
}
