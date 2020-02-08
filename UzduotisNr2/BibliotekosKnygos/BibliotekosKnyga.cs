using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekosKnygos
{
    public class BibliotekosKnyga
    {
        public int KnygosId { get; private set; }
        public string Pavadinimas { get; private set; }
        public int Terminas { get; private set; }
        public string SkaitytojoVardas { get; set; }
        public DateTime PaemimoData { get; set; }

        public BibliotekosKnyga(int knygosId, string pavadinimas, int terminas)
        {
            KnygosId = knygosId;
            Pavadinimas = pavadinimas;
            Terminas = terminas;
        }
        public bool TikrinameArVeluojaGrazinti()
        {
            bool velavimas;
            double KiekDienuPaimtaKnyga = (DateTime.Now - PaemimoData).TotalDays;

            if(KiekDienuPaimtaKnyga > Terminas)
            {
                velavimas = true;
            }
            else
            {
                velavimas = false;
            }
            return velavimas;

        }

    }


}
