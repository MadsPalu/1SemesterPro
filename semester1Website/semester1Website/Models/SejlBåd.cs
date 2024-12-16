namespace semester1Website.Models
{
    public class SejlBåd : Båd
    {
        #region Properties
        public int _antalSejl { get; set; }
        public double _maksSejlBredde { get; set; }
        #endregion

        #region Constructors
        public SejlBåd(string navn, string model, int byggeÅr, string mål, int antalSejl, double maksSejlBredde)
          : base(navn, "Sejlbåd", model, byggeÅr, mål)
        {
            _antalSejl = antalSejl;
            _maksSejlBredde = maksSejlBredde;
        }
        #endregion

        #region Methods
        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Antal Sejl: {_antalSejl}, Maks Sejl Bredde: {_maksSejlBredde}";
        }
        #endregion
    }
}
