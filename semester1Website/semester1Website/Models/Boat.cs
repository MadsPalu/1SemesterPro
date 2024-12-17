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
        public static int IdCounter = 1;
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
