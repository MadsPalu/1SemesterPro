﻿

namespace semester1Website.Models
{
    public class BookingRepo
    {
        #region Instance Fields
        private static List<Booking> _bookinger = new List<Booking>();
        #endregion

        #region Methods
        public void Lavbooking(Booking booking)
        {
            if (booking._startTid >= booking._slutTid)
            {
                throw new ArgumentNullException("Starttidspunkt skal være før sluttidspunkt");

            }
            _bookinger.Add(booking);
            Console.WriteLine($"Booking oprettet med Booking Id: {booking._bookingId}\nog Båd Id: {booking._boatId}");
        }
    
        public void SletBooking(Booking booking)
        {
            _bookinger.Remove(booking);
            Console.WriteLine($"Booking med ID {booking._bookingId} er blevet fjernet");
        }
    
        public List<Booking> HentAlleBookinger()
        {
            return _bookinger;
        }
        #endregion
    }
}