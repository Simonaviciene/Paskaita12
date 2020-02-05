using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace UzduotisNr1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NameAndSurname nameAndSurname = new NameAndSurname("Vilija", "Simonaviciene");
            //Console.WriteLine("Vardas: {0}, \nPavarde: {1}", nameAndSurname.Vardas, nameAndSurname.Pavarde);
            //Console.ReadLine();

            DateTime dateTime = new DateTime(1989, 01, 25);
            AsmensDuomenys asmensDuomenys = new AsmensDuomenys("Vilija", "Simonaviciene", dateTime);
            Console.WriteLine("Vardas: {0}, \nPavarde: {1}, \nGimimo metai: {2} ", asmensDuomenys.Vardas, asmensDuomenys.Pavarde, dateTime.ToString());
            Console.ReadLine();
        }


    }
}
