namespace semester1Website.Models
{
    public class GenericRepo<T>
    {
        public Dictionary<int, T> Items = new Dictionary<int, T>();
        //bruges til at finde ID i de forskellige repo
        public Func<T, int> GetIdFunc;
        public JsonHandler<T> JsonHandler;

        public GenericRepo(string filePath, Func<T, int> getIdFunc)
        {
            GetIdFunc = getIdFunc;
            JsonHandler = new JsonHandler<T>(filePath);
            Items = JsonHandler.LoadFromFile();
        }

        public void Add(T item)
        {
            int id = GetIdFunc(item);
            Items.Add(id, item);
            JsonHandler.SaveToFile(Items);
        }

        public T Get(int id)
        {
            return Items[id];
        }

        public void Remove(int id)
        {
            Items.Remove(id);
            JsonHandler.SaveToFile(Items);
        }

        public string PrintAll()
        {
            string output = "";
            foreach (var item in Items)
            {
                output += $"{item} ";
            }
            return output;
        }
    }
}
