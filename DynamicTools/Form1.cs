using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            Point buttonKonum = new Point(20 , 10);
            button.Location = buttonKonum;
            button.Name = "Button1";
            button.Text = "Tıkla";
            button.BackColor = Color.Green;
            button.Height = 50;
            button.Width = 75;

            Label label = new Label();
            Point labelKonum = new Point();
            labelKonum.X = 300;
            labelKonum.Y = 20;
            label.Location = labelKonum;
            label.Name = "Label1";
            label.Text = "Merhaba";
            label.BackColor = Color.Purple;
            label.Height = 50;
            label.Width = 75;
            this.Controls.Add(label);
            this.Controls.Add(button);
        }
    }
}
