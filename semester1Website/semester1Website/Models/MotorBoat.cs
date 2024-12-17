using System.Text.Json.Serialization;

namespace semester1Website.Models
{
    public class MotorBoat : Boat
    {
        public string Motor { get; set; }
        public int HorsePower { get; set; }
        public double Liter { get; set; }

        public MotorBoat(string name, string model, int buildYear, string dimensions, string motor, int horsePower, double liter) 
            : base(name, "Motor Boat", model, buildYear, dimensions)
        {
            Motor = motor;
            HorsePower = horsePower;
            Liter = liter;
        }

        //Bruger båds override some base og sætter de nye info med.
        public override string ToString()
        {
            string baseInfo = base.ToString();
            return $"{baseInfo}, Motor: {Motor}, Horse Power: {HorsePower}, Liter: {Liter}";
        }
    }
}
