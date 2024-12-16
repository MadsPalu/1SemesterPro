using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public static class MedlemsRepository
    {
        #region Instance Fields
        private static Dictionary<int, Medlem> _medlemsListe = new Dictionary<int, Medlem>();
        #endregion

        #region Methods
        //lav exeption medlem allerede i liste.
        public static void AddMedlem(Medlem medlem) 
        {
            _medlemsListe.Add(medlem.HentMedlemsNummer(), medlem);
        }

        public static void PrintListe() 
        {
            Console.WriteLine("Medlemsliste:");
            foreach (KeyValuePair<int, Medlem> medlem in _medlemsListe)
            {
                Console.WriteLine($"{medlem.Value.HentInfo()} medlemsnummer: {medlem.Key}");
            }
        }
        
        //lav exeption, medlem not found.
        public static Medlem GetMedlem(int id) 
        {
            return _medlemsListe[id];
        }

        //tjek exeption i GetMedlem, også gælder her
        public static void RemoveMedlem(int id) 
        {
            _medlemsListe.Remove(id);
        }
        #endregion
    }
}

