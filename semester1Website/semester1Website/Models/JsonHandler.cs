using System.Text.Json;

namespace semester1Website.Models
{
    public class JsonHandler<T>
    {
        public string FilePath { get; set; }


        public JsonHandler(string filePath) 
        {
            FilePath = filePath;
        }

        //bliver kaldt i program.cs
        public Dictionary<int, T> LoadFromFile()
        {
            Dictionary<int, T> loadList = new Dictionary<int, T>();
            if (File.Exists(FilePath))
            {
                //læser document ved pathen.
                string json = File.ReadAllText(FilePath);
                //ændre json texten tilbage til C# og propper det tilbage i MemberRepoet 
                loadList = JsonSerializer.Deserialize<Dictionary<int, T>>(json);

                //Gemmer tæleren til membercounter, ved at tælle antelet af keys i memberlisten efter den er loaded fra json
                if (loadList.Count > 0 && typeof(T) == typeof(Member))
                {
                    Member.MemberNumberCounter = loadList.Keys.Max() + 1;
                }

                if (loadList.Count > 0 && typeof(T) == typeof(Boat))
                {
                    Boat.IdCounter = loadList.Keys.Max() + 1;
                }
            }
            return loadList;
        }

        //kalder den i add og remove member så den opdater json listen ved ændring.
        public void SaveToFile(Dictionary<int, T> saveList)
        {
            //laver en Json Serializer der kan lave klassen til Json
            string json = JsonSerializer.Serialize(saveList);
            //Gemmer Json data ved file pathen, laver ny fil hvis den ikke findes.
            File.WriteAllText(FilePath, json);
        }
    }
}
