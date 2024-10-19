using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleDegiskenlerOgrenciSistemiProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string studentName, studentSurname, studenGrade;
            double studentNumber;
            double exam1, exam2, exam3, examAverage;

            studentName = Convert.ToString(textBox1.Text);
            studentSurname = Convert.ToString(textBox2.Text);
            studenGrade = Convert.ToString(textBox3.Text);

            studentNumber = Convert.ToDouble(maskedTextBox1.Text);

            exam1 = Convert.ToDouble(textBox4.Text);
            exam2 = Convert.ToDouble(textBox5.Text);
            exam3 = Convert.ToDouble(textBox6.Text);

            examAverage = (exam1 + exam2 + exam3) / 3;

            label9.Text = studentName;
            label10.Text = studentSurname;
            label11.Text = studentNumber.ToString();
            label12.Text = studenGrade;
            label13.Text = exam1.ToString();
            label14.Text = exam2.ToString();
            label15.Text = exam3.ToString();
            label16.Text = examAverage.ToString();

            listBox1.Items.Add("**** Öğrenci Bilgileri: ****");
            listBox1.Items.Add("Öğrenci Adı: " + studentName + " Öğrenci Soyadı: " + studentSurname + " Öğrenci Numarası: " + studentNumber + " Öğrenci Sınıfı: " + studenGrade);
            listBox1.Items.Add("**** Sınav Bilgileri ****");
            listBox1.Items.Add("1.Sınav Notu " + exam1 + " 2.Sınav Notu: " + exam2 + " 3.Sınav Notu: " + exam3 + " Ortalama: " + examAverage);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();

            maskedTextBox1.Clear();

            MessageBox.Show("Öğrenci Kaydedildi Sıradaki Kayda Geçin!");
        }
    }
}
