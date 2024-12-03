namespace semester1Website.Models
{
    public class Boat
    {
        public string Name { get; set; }
        public string BoatType { get; set; }
        public string Model { get; set; }
        //skal kun være på nedarvet klasser af både der er "motorbåde", andre ex. robåde sejlbåde.
        //public string _motor { get; set; }

        private static int IdCounter = 1;
       //tror måske det skulle have være det jeg har kaldt antalSejl i sejlbåd, tænkte sejlnummer var en slags IdCounter.
        public int Id { get; set; }
        public int BuildYear { get; set; }
        //skriv som "Højde*Bredde*længde"
        public string Dimensions { get; set; }
        
        public Boat(string name, string boatType, string model, int buildYear, string dimensions)
        {
            Id = IdCounter++;
            Name = name;
            BoatType = boatType;
            Model = model;
            BuildYear = buildYear;
            Dimensions = dimensions;
        }

        //overvej om det giver menning at kunne skifte værdier, fleste giver ikke menning.

        public int GetId() 
        {
            return Id; 
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {BoatType}, Model: {Model}, " +
                   $"Id: {Id}, Build Year: {BuildYear}, Dimensions: {Dimensions}";
        }
    }
}
