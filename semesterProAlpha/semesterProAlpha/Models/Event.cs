namespace semester1Website.Models
{
    public class Event
    {
        #region Properties
        public string Date { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; } 
        public static List<Event> Events { get; set; } = new List<Event>(); 
        #endregion

        #region Constructors    
        public Event(string date, string title, string description, string location)
        {
            Date = date;
            Title = title;
            Description = description;
            Location = location;
        }
        #endregion

        #region Methods
        public static void AddEvent(Event events)
        {
            Events.Add(events);
        }
        #endregion
    }
}