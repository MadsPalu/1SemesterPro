using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public class Båd
    {
        public string _navn { get; set; }
        public string _bådType { get; set; }
        public string _model { get; set; }
        //skal kun være på nedarvet klasser af både der er "motorbåde", andre ex. robåde sejlbåde.
        //public string _motor { get; set; }

        private static int _sejlnummerCounter = 1;
       //tror måske det skulle have være det jeg har kaldt antalSejl i sejlbåd, tænkte sejlnummer var en slags id.
        public int _sejlnummer { get; set; }
        public int _byggeÅr { get; set; }
        //skriv som "Højde*Bredde*længde"
        public string _mål { get; set; }
        
        public Båd(string navn, string bådType, string model, int byggeÅr, string mål)
        {
            _sejlnummer = _sejlnummerCounter++;
            _navn = navn;
            _bådType = bådType;
            _model = model;
            _byggeÅr = byggeÅr;
            _mål = mål;
        }

        //overvej om det giver menning at kunne skifte værdier, fleste giver ikke menning.

        public int GetSejlNummer() 
        {
            return _sejlnummer; 
        }

        public override string ToString()
        {
            return $"Navn: {_navn}, Type: {_bådType}, Model: {_model}, " +
                   $"Sejlnummer: {_sejlnummer}, Byggeår: {_byggeÅr}, Mål: {_mål}";
        }
    }
}
