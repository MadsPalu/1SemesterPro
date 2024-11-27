using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public static class BådRepository
    {
        private static Dictionary<int, Båd> _bådListe = new Dictionary<int, Båd>();

        //lav exeption båd allerede i liste.
        public static void AddBåd(Båd båd)
        {
           _bådListe.Add(båd.GetSejlNummer(), båd);
        }

        public static void PrintListe()
        {
            Console.WriteLine("Bådliste:");
            foreach (KeyValuePair<int, Båd> båd in _bådListe)
            {
                
                Console.WriteLine(båd.Value.ToString());
                //Console.WriteLine($"{båd.Value.ToString()} Sejlnummer: {båd.Key}");
            }
        }

        //lav exeption, båd not found.
        public static Båd GetBåd(int id)
        {
            return _bådListe[id];
        }

        //tjek exeption i GetBåd, også gælder her
        public static void RemoveBåd(int id)
        {
            _bådListe.Remove(id);
        }
    }
}

