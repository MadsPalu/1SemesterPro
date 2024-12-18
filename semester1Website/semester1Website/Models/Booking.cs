namespace semester1Website.Models
{
    public class Booking
    {
        private static int _bookingIdCounter = 1;

        public int _bookingId { get; private set; }
        public int _boatId { get; set; }
        public DateTime _startTid { get; set; }
        public DateTime _slutTid { get; set; }

        public Booking(int boatId, DateTime startTid, DateTime slutTid)
        {
            _boatId = boatId;
            _bookingId = _bookingIdCounter++;
            _startTid = startTid;
            _slutTid = slutTid;
        }

        public override string ToString()
        {
            return $"Booking ID: {_bookingId}\n" +
                   $"Båd ID: {_boatId}\n" +
                   $"Fra: {_startTid}\n" +
                   $"Til: {_slutTid}";
        }
    }
}