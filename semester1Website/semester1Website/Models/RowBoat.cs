using System.Text.Json.Serialization;

namespace semester1Website.Models
{
    public class RowBoat : Boat
    {
        #region Properties
        public int Seats { get; set; }
        public int NumberOfOars { get; set; }
        #endregion

        #region Constructors
        public RowBoat(string name, string model, int buildYear, string dimensions, int seats, int numberOfOars)
          : base(name, "Row Boat", model, buildYear, dimensions)
        {
            Seats = seats;
            NumberOfOars = numberOfOars;
        }
        #endregion

        #region Methods
        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Seats: {Seats}, Number of oars: {NumberOfOars}";
        }
        #endregion
    }
}
