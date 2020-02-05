using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public struct AsmensDuomenys
    {
        public string Vardas, Pavarde;
        public DateTime GimimoMetai { get; private set; }
        public DateTime SiandienosData { get; private set; }
        

        

        public AsmensDuomenys(string vardas, string pavarde, DateTime gimimoMetai, DateTime siandienosData)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoMetai;
            SiandienosData = siandienosData;
        }
        public static int GetAge()
        {
            int metai = 0;
            metai = DateTime.Now.Year - 
        }
   
    } 
   
    


    
    //public class NameAndSurname
    //{
    //    public string Vardas { get; private set; }
    //    public string Pavarde { get; private set; }

    //    public NameAndSurname(string vardas, string pavarde)
    //    {
    //        Vardas = vardas;
    //        Pavarde = pavarde;
    //    }
    //}
    
}
