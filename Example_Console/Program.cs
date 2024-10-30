using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int age;
            string job;
            int x, y;
            char operationS;
            Message message = new Message();
            People people = new People();
            Operation operation = new Operation();

            message.Sentence();

            people.ListOfPeople("Betül Salim", 21, "İntern Backend Developer");
            //Console.Write("Kişi ismini ve soyismini giriniz: ");
            //string nameSurname = Console.ReadLine();
            //Console.Write("Kişinin Yaşını giriniz: ");
            //age = int.Parse(Console.ReadLine());
            //Console.Write("Kişinin Mesleğini giriniz: ");
            //job = Console.ReadLine();
            //people.ListOfPeople(nameSurname, age, job);

            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("******* HESAP MAKİNESİ ******");
            //Console.WriteLine();
            //Console.Write("İşlem yapmak istediğiniz ilk sayıyı giriniz: ");
            //x = int.Parse(Console.ReadLine());
            //Console.Write("İşlem yapmak istediğiniz ikinci sayıyı giriniz: ");
            //y = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------");
            //Console.WriteLine();

            //Console.WriteLine("yapmak istediğiniz işlemi seçiniz (+, -, *, /): ");
            //operationS = char.Parse(Console.ReadLine());

            //switch(operationS)
            //{
            //    case '+':
            //        operation.sum(x, y);
            //        break;
            //    case '-':
            //        operation.subtraction(x, y);
            //        break;
            //    case '*':
            //        operation.multiplication(x, y);
            //        break;
            //    case '/':
            //        operation.divide(x, y);
            //        break;
            //}


            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------------");
            //Console.Write("Adı: ");
            //string studentName = Console.ReadLine();
            //Console.Write("Soyadı: ");
            //string studentSurname = Console.ReadLine();
            //Console.Write("Yaşı: ");
            //int studentAge = int.Parse(Console.ReadLine());
            //Console.Write("Üye olduğu Kulüp: ");
            //string studentClub = Console.ReadLine();
            //Student student = new Student(studentName, studentSurname,studentAge,studentClub);//constructor olduğunda sadece nesne oluşturmak yeterli
            Id id = new Id();
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine(id.NAME);
            Console.WriteLine(id.SURNAME);
            Console.WriteLine(id.BIRTHAGE);
            Console.WriteLine(id.BIRTHPLACE);
            Console.WriteLine(id.GENDER);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.Write("Adı: ");
            string name = Console.ReadLine();
            Console.Write("Soyadı: ");
            string surname = Console.ReadLine();
            Console.Write("Doğum Tarihi: ");
            int birthDate = int.Parse(Console.ReadLine());
            int age = 2024 - birthDate;
            Console.Write("Doğum Yeri: ");
            string birthPlace = Console.ReadLine();
            Console.Write("Cinsiyet (K/E): ");
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            
            id.GENDER = gender;
            id.NAME = name;
            id.SURNAME = surname;
            id.BIRTHDATE = birthDate;
            id.BIRTHAGE = age;
            id.BIRTHPLACE = birthPlace;
            Console.WriteLine("Ad: " + id.NAME + "\nSoyad: " + id.SURNAME + "\nDoğum Tarihi: " + id.BIRTHDATE + "\nYaşı: " + id.BIRTHAGE + "\nDoğum Yeri: " + id.BIRTHPLACE + "\nCinsiyet (K/E): " + id.GENDER);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
