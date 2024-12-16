using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace semesterProAlpha
{
    public class Medlem
    {
        public static int _medlemsNummerCounter = 1;
        public bool IsLoggedIn;
        string _Name;
        string _Mobile;
        string _Addresse;
        int _MedlemsNummer;

        public Medlem(string name, string mobile, string addresse) 
        {
            _MedlemsNummer = _medlemsNummerCounter++;
            _Name = name;
            _Mobile = mobile;
            _Addresse = addresse;
        }


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

        public void ChangeAddresse(string addresse) { 
            _Addresse = addresse;
        }

        //når både klasse er lavet, lav list over både som medlem eger

        //lav bool tjek, (er ude og sejle)
    }
}
