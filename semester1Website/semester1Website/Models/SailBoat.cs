namespace semester1Website.Models
{
    public class SailBoat : Boat
    {
        public int SailAmount { get; set; }
        public double MaxSailWidth { get; set; }

        public SailBoat(string name, string model, int buildYear, string dimensions, int sailAmount, double maxSailWidth)
          : base(name, "Sail Boat", model, buildYear, dimensions)
        {
            SailAmount = sailAmount;
            MaxSailWidth = maxSailWidth;
        }

        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Sail amount: {SailAmount}, Max sail width: {MaxSailWidth}";
        }
    }
}
