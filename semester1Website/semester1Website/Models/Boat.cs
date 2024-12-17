using System.Text.Json.Serialization;

namespace semester1Website.Models
{
    [JsonDerivedType(typeof(Boat), "Boat")]
    [JsonDerivedType(typeof(MotorBoat), "MotorBoat")]
    [JsonDerivedType(typeof(SailBoat), "SailBoat")]
    [JsonDerivedType(typeof(RowBoat), "RowBoat")]
    public class Boat
    {
        #region Properties
        public string Name { get; set; }
        public string BoatType { get; set; }
        public string Model { get; set; }
        //skal kun være på nedarvet klasser af både der er "motorbåde", andre ex. robåde sejlbåde.
        //public string _motor { get; set; }

        public static int IdCounter = 1;
       //tror måske det skulle have være det jeg har kaldt antalSejl i sejlbåd, tænkte sejlnummer var en slags IdCounter.
        public int Id { get; set; }
        public int BuildYear { get; set; }
        //skriv som "Højde*Bredde*længde"
        public string Dimensions { get; set; }
        #endregion
        
        #region Constructors
        public Boat(string name, string boatType, string model, int buildYear, string dimensions)
        {
            Id = IdCounter++;
            Name = name;
            BoatType = boatType;
            Model = model;
            BuildYear = buildYear;
            Dimensions = dimensions;
        }
        #endregion
        //overvej om det giver menning at kunne skifte værdier, fleste giver ikke menning.
        #region Methods
        public int GetId() 
        {
            return Id; 
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {BoatType}, Model: {Model}, " +
                   $"Id: {Id}, Build Year: {BuildYear}, Dimensions: {Dimensions}";
        }
        #endregion
    }
}
