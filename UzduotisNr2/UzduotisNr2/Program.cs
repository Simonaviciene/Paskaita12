using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotekosKnygos;

namespace UzduotisNr2
{
    public class Program
    {
        static void Main(string[] args)
        {
            BibliotekosKnyga bibliotekosKnyga = new BibliotekosKnyga(1, "Pasaka", 20);

            bibliotekosKnyga.SkaitytojoVardas = "Mantas";
            bibliotekosKnyga.PaemimoData = new DateTime(2020, 1, 1);

            Console.WriteLine("KnygosId: {0}, Knygos pavadinimas: {1}, Terminas: {2}," +
                "Skaitytojo Vardas{3}, Ar veluoja garzinti knyga?: {4}, ", 
                bibliotekosKnyga.KnygosId, bibliotekosKnyga.Pavadinimas, 
                bibliotekosKnyga.Terminas, bibliotekosKnyga.SkaitytojoVardas,
                bibliotekosKnyga.TikrinameArVeluojaGrazinti());
            Console.ReadLine();
        }
    }
}
