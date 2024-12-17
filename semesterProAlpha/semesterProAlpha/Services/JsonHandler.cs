using System.Text.Json;

namespace semesterProAlpha.Services
{
    public class JsonHandler<T>
    {
        #region Properties
        public string FilePath { get; set; }
        public int Counter { get; set; }
        #endregion

        #region Constructors
        public JsonHandler(string filePath)
        {
            FilePath = filePath;
        }
        #endregion

        #region Methods
        public Dictionary<int, T> LoadFromFile()
        {
            Dictionary<int, T> loadList = new Dictionary<int, T>();
            if (File.Exists(FilePath))
            {
                //læser document ved pathen.
                string json = File.ReadAllText(FilePath);
                //ændre json texten tilbage til C# og propper det tilbage i Repoet 
                loadList = JsonSerializer.Deserialize<Dictionary<int, T>>(json);

                //Gemmer tæleren til Id Counter, ved at tælle antelet af keys i listen efter den er loaded fra json
                Counter = loadList.Keys.Max() + 1;
            }
            return loadList;
        }

        //kalder den i add og remove i repoet så den opdater json listen ved ændring.
        public void SaveToFile(Dictionary<int, T> saveList)
        {
            //laver en Json Serializer der kan lave klassen til Json
            string json = JsonSerializer.Serialize(saveList);
            //Gemmer Json data ved file pathen, laver ny fil hvis den ikke findes.
            File.WriteAllText(FilePath, json);
        }
        #endregion
    }
}
