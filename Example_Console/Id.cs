using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class Id
    {
        string name, surname, birthPlace;
        int birthDate, age;
        char gender;
        
           
       public string NAME
        {
            get { return name; }
            set { name = value.ToLower(); }
        }

       public string SURNAME
        {
            get { return surname; }
            set { surname = value.ToUpper(); }
        }

       public string BIRTHPLACE { get { return birthPlace; } set { birthPlace = value.ToLower(); }}
       public int BIRTHDATE { get { return birthDate; } set { birthDate = Math.Abs(value); }}
       public int BIRTHAGE { get { return age; } set { age = Math.Abs(value); }}
       public char GENDER { get { return gender; } set {gender = value; }}

        public Id () //yazılmazsa bu bailangıç değeri olarak kabul ediyor.
        {
            name = "";
            surname = "";
            age = 18;
            birthDate = 2005;
            gender = 'K';
            birthPlace = "Ankara";
        }

        
    }
}
