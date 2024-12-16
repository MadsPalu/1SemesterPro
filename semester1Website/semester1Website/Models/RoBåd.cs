namespace semester1Website.Models
{
    public class RoBåd : Båd
    {
        #region Properties
        public int _siddePladser { get; set; }
        public int _antalÅrer { get; set; }
        #endregion

        #region Constructors
        public RoBåd(string navn, string model, int byggeÅr, string mål, int siddePladser, int antalÅrer)
          : base(navn, "Robåd", model, byggeÅr, mål)
        {
            _siddePladser = siddePladser;
            _antalÅrer = antalÅrer;
        }
        #endregion

        #region Methods
        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Sidde Pladser: {_siddePladser}, Antal Årer: {_antalÅrer}";
        }
        #endregion
    }
}
