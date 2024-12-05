using System.Text.Json;

namespace semester1Website.Models
{
    public static class BoatRepository
    {
        private static Dictionary<int, Boat> BoatList = new Dictionary<int, Boat>();
        private static string FilePath = "boatData.json";

        //lav exeption Boat allerede i List.
        public static void AddBoat(Boat Boat)
        {
           BoatList.Add(Boat.GetId(), Boat);
           SaveToFile();
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
            SaveToFile();
        }

        //læs kommentar i memberlist for beskrivelse
        public static void SaveToFile()
        {
            string json = JsonSerializer.Serialize(BoatList);
            File.WriteAllText(FilePath, json);
        }

        public static void LoadFromFile()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                BoatList = JsonSerializer.Deserialize<Dictionary<int, Boat>>(json);

                if (BoatList.Count > 0)
                {
                    Boat.IdCounter = BoatList.Keys.Max() + 1;
                }
            }
        }
    }
}

