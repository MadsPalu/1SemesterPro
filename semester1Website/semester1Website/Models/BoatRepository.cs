namespace semester1Website.Models
{
    public static class BoatRepository
    {
        private static Dictionary<int, Boat> BoatList = new Dictionary<int, Boat>();

        //lav exeption Boat allerede i List.
        public static void AddBoat(Boat Boat)
        {
           BoatList.Add(Boat.GetId(), Boat);
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
        }
    }
}

