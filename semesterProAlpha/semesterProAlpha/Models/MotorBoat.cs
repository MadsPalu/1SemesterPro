namespace semesterProAlpha.Models
{
    public class MotorBoat : Boat
    {
        #region Properties
        public string Motor { get; set; }
        public int HorsePower { get; set; }
        public double Liter { get; set; }
        #endregion

        #region Constructors
        public MotorBoat(string name, string model, int buildYear, string dimensions, string motor, int horsePower, double liter) 
            : base(name, "Motor Boat", model, buildYear, dimensions)
        {
            Motor = motor;
            HorsePower = horsePower;
            Liter = liter;
        }
        #endregion

        
        #region Methods
        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Motor: {Motor}, Horse Power: {HorsePower}, Liter: {Liter}";
        }
        #endregion
    }
}
