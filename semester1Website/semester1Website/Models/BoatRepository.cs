using System.Runtime.CompilerServices;
using System.Text.Json;

namespace semester1Website.Models
{
    public static class BoatRepository
    {
        #region Instance Fields
        private static string FilePath = "boatData.json";
        public static JsonHandler<Boat> JsonHandler = new JsonHandler<Boat>(FilePath);
        private static Dictionary<int, Boat> BoatList = JsonHandler.LoadFromFile();
        #endregion
        
        #region Methods
        //lav exeption Boat allerede i List.
        public static void AddBoat(Boat Boat)
        {
           BoatList.Add(Boat.GetId(), Boat);
           JsonHandler.SaveToFile(BoatList);
        }

        public static string PrintList()
        {
            string boatList = "";
            Console.WriteLine("BoatList:");
            foreach (KeyValuePair<int, Boat> Boat in BoatList)
            {
                boatList += ($"{Boat.Value.ToString()} ");
            }
            return boatList;
        }

        //lav exeption, Boat not found.
        public static Boat GetBoat(int id)
        {
            return BoatList[id];
        }

        //tjek exeption i GetBoat, også gælder her
        public static void RemoveBoat(int id)
        {
            BoatList.Remove(id);
            JsonHandler.SaveToFile(BoatList);
        }
        #endregion
    }
}


