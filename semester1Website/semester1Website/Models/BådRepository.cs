namespace semester1Website.Models
{
    public static class BådRepository
    {
        private static Dictionary<int, Båd> _bådListe = new Dictionary<int, Båd>();

        //lav exeption båd allerede i liste.
        public static void AddBåd(Båd båd)
        {
           _bådListe.Add(båd.GetSejlNummer(), båd);
        }

        public static string PrintListe()
        {
            string bådliste = "";
            Console.WriteLine("Bådliste:");
            foreach (KeyValuePair<int, Båd> båd in _bådListe)
            {
                bådliste += ($"{båd.Value.ToString()} ");
            }
            return bådliste;
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

