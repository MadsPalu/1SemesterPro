using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public class SejlBåd : Båd
    {
        public int _antalSejl { get; set; }
        public double _maksSejlBredde { get; set; }

        public SejlBåd(string navn, string model, int byggeÅr, string mål, int antalSejl, double maksSejlBredde)
          : base(navn, "Sejlbåd", model, byggeÅr, mål)
        {
            _antalSejl = antalSejl;
            _maksSejlBredde = maksSejlBredde;
        }

        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Antal Sejl: {_antalSejl}, Maks Sejl Bredde: {_maksSejlBredde}";
        }
    }
}
