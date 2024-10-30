using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class Student
    {
        
            
            
            
        public Student(string studentName, string studentSurname, int studentAge, string studentClub)
        {
            //Console.WriteLine("Ad: Baran");
            //Console.WriteLine("Soyad: Yücedağ");
            //Console.WriteLine("Meslek: Öğretmen");
            
            Console.WriteLine("Ad: " + studentName + " Soyad: " + studentSurname + " Yaş: " + studentAge + " Kulüp: " + studentClub);
        }

    }
}
