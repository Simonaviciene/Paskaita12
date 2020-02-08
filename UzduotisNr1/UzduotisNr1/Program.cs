using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsmensDuomenysLibrary;

namespace UzduotisNr1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //NameAndSurname nameAndSurname = new NameAndSurname("Vilija", "Simonaviciene");
            //Console.WriteLine("Vardas: {0}, \nPavarde: {1}", nameAndSurname.Vardas, nameAndSurname.Pavarde);
            //Console.ReadLine();

            DateTime gimimoData = new DateTime(1989, 01, 25);
            
            AsmensDuomenys asmensDuomenys = new AsmensDuomenys("Vilija", "Simonaviciene", gimimoData);
            int metai = asmensDuomenys.GetAge();
            Console.WriteLine(
                "Vardas: {0}, \nPavarde: {1}, \nGimimo metai: {2} \nManoAmzius {3}", 
                asmensDuomenys.Vardas, asmensDuomenys.Pavarde, asmensDuomenys.GimimoMetai.ToShortDateString(), metai);
            Console.ReadLine();
        }


    }
}
