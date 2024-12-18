using semester1Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semester1Website;

public class AktivebookingerModel : PageModel
{
    private static BookingRepo _bookingRepo = new BookingRepo();

    public List<Booking> Bookinger { get; private set; } = new List<Booking>();

    public void OnGet()
    {
        // Henter alle bookinger fra repo
        Bookinger = _bookingRepo.HentAlleBookinger();
    }
}

