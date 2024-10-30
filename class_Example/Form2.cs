using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_Example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Car car = new Car();

            car.color = "Red";
            car.speed = 180;
            car.engineStregnth = 1300.60;
            car.carPrice = 80000;
            car.status = 'S';

            label1.Text = car.color;
            label2.Text = car.speed.ToString();
            label3.Text = car.engineStregnth.ToString();
            label4.Text = car.carPrice.ToString();
            label5.Text = car.status.ToString();
        }
    }
}
