using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsmensDuomenysLibrary

{
    public struct AsmensDuomenys
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public DateTime GimimoMetai { get; private set; }
        



        public AsmensDuomenys(string vardas, string pavarde, DateTime gimimoMetai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            GimimoMetai = gimimoMetai;
            
        }
        public int GetAge()
        {

            int metai = 0;
            metai = (DateTime.Now.Year - GimimoMetai.Year);
            return metai;
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
