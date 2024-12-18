using semester1Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semester1Website;

public class BookboatModel : PageModel
{
    private static BookingRepo _bookingRepo = new BookingRepo();
    public List<Booking> Bookinger { get; private set; } = new List<Booking>();

    [BindProperty]
    public int _boatId { get; set; }
    [BindProperty]
    public DateTime _startTid { get; set; }
    [BindProperty]
    public DateTime _slutTid { get; set; }

    public string Message { get; set; }


    public void OnGet()
    {
        //Henter alle bookinger fra BookingRepo
        Bookinger = _bookingRepo.HentAlleBookinger();
    }
    public IActionResult OnPost()
    {
        if (ModelState.IsValid)
        {
            //opretter en ny booking og tilføj den til repo
            Booking newBooking = new Booking(_boatId, _startTid, _slutTid);
            _bookingRepo.Lavbooking(newBooking);

            
            Message = $"Booking for båd {_boatId} er oprettet";
            return Page();
        }

        Message = "Noget gik galt. Prøv igen!";
        return Page();
    }
}