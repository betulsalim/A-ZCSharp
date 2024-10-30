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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //car sınıfından car isminde bir car nesnesi ürettim
            Car car = new Car();

            car.color = "blue";
            car.speed = 160;
            car.engineStregnth = 1245.56;
            car.carPrice = 50000;
            car.status = 'S';
            car.YEAR = -2016;
            car.MODEL = "golf";
            car.vehicleInspection = 2017;
            car.licensePlate = "34 Aİ 1881";
            car.owner = "Zübeyde Hanım";

            label1.Text = car.color;
            label2.Text = car.speed.ToString();
            label3.Text = car.engineStregnth.ToString();
            label4.Text = car.carPrice.ToString();
            label5.Text = car.status.ToString();
            label6.Text = car.YEAR.ToString();
            label7.Text = car.MODEL;
            label8.Text = car.vehicleInspection.ToString();
            label9.Text = car.licensePlate;
            label10.Text = car.owner;
        }
    }
}
