using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Example
{
    internal class Car: CarDetail //kalıtım
    {
        public string color;
        public int speed;
        public double engineStregnth;
        public char status;
        public int carPrice;
        private int year;
        private string model;

        public int  YEAR // kapsülleme
        {
            get 
            { 
                return year;
            }
            set { year = Math.Abs(value); }  // yıl negatif değer girilirse negatif değeri engelleyecek ve pozitif olarak karşıma çıkaracak.
        }

        public string MODEL { get { return model; } set { model = value.ToUpper(); } }


    }
} 
