using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public class RoBåd : Båd
    {
        public int _siddePladser { get; set; }
        public int _antalÅrer { get; set; }

        public RoBåd(string navn, string bådType, string model, int byggeÅr, string mål, int siddePladser, int antalÅrer)
          : base(navn, bådType, model, byggeÅr, mål)
        {
            _siddePladser = siddePladser;
            _antalÅrer = antalÅrer;
        }

        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Sidde Pladser: {_siddePladser}, Antal Årer: {_antalÅrer}";
        }
    }
}
