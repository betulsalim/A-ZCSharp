using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class People
    {
        public void ListOfPeople (string nameSurname, int age, string job)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " - " + nameSurname + " Yaşı: " + age + " Mesleği: " + job);
            }
           
        }
    }
}
