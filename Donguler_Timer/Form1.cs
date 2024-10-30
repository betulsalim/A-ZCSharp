using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10 )
            {
                label1.BackColor = Color.Red;
            }
            
            if (progressBar1.Value % 20 == 0)
            {
                if (progressBar1.Value == 100)
                {
                    label1.BackColor = Color.Green;
                }
                else
                {
                    label1.BackColor = Color.White;
                }
            }
            if (progressBar1.Value == 100 )
            {
                timer1.Stop();
                MessageBox.Show("!!! Un ve Ymurta Karıştırıldı !!!");
                
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Red;
            }

            if (progressBar2.Value % 10 == 0)
            {
                if (progressBar2.Value == 100)
                {
                    label2.BackColor = Color.Green;
                }
                else
                {
                    label2.BackColor = Color.White;
                }
            }
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                MessageBox.Show("!!! Çırpma İşlemi Tamamlandı !!!");
                
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 4;
            if (progressBar3.Value % 8 == 4)
            {
                if (progressBar3.Value == 100)
                {
                    label3.BackColor = Color.Green;
                }
                else
                {
                    label3.BackColor = Color.Red;
                }
                
            }

            if (progressBar3.Value % 8 == 0)
            {
                if (progressBar3.Value == 100)
                {
                    label3.BackColor = Color.Green;
                }
                else
                {
                    label3.BackColor = Color.White;
                }
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("!!! Malzemeler Eklendi Ve Karıştırıldı !!!");

                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 2;
            if (progressBar4.Value % 4 == 2)
            {
                label5.BackColor = Color.Red;
            }

            if (progressBar4.Value % 4 == 0)
            {
                if (progressBar4.Value == 100)
                {
                    label5.BackColor = Color.Green;
                }
                else
                {
                    label5.BackColor = Color.White;
                }
            }
            if (progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("!!! Pişirme İşlemi Tamamlandı !!!");

               
            }
        }
    }
}
