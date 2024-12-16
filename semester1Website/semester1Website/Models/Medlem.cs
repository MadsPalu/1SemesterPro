namespace semester1Website.Models
{
    public class Medlem
    {
        #region Instance Fields
        string _Name;
        string _Mobile;
        string _Addresse;
        int _MedlemsNummer;
        #endregion

        #region Properties
        public static int _medlemsNummerCounter = 1;
        #endregion

        #region Constructors
        public Medlem(string name, string mobile, string addresse)
        {
            _MedlemsNummer = _medlemsNummerCounter++;
            _Name = name;
            _Mobile = mobile;
            _Addresse = addresse;
        }
        #endregion

        #region Methods
        //eventuelt bare lav override på tostring
        public string HentInfo()
        {
            return $"Navn: {_Name}, Mobil: {_Mobile} Addresse: {_Addresse}";
        }

        public int HentMedlemsNummer()
        {
            return _MedlemsNummer;
        }

        public void ChangeName(string name)
        {
            _Name = name;
        }

        public void ChangeMobile(string mobile)
        {
            _Mobile = mobile;
        }

        public void ChangeAddresse(string addresse)
        {
            _Addresse = addresse;
        }
        #endregion

        //når både klasse er lavet, lav list over både som medlem eger

        //lav bool tjek, (er ude og sejle)
    }
}
