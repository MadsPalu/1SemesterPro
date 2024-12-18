using semester1Website.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semester1Website;

public class AktivebookingerModel : PageModel
{
    #region Instance Fields
    private static BookingRepo _bookingRepo = new BookingRepo();
    #endregion

    #region Properties
    public List<Booking> Bookinger { get; private set; } = new List<Booking>();
    #endregion

    #region Methods
    public void OnGet()
    {
        // Henter alle bookinger fra repo
        Bookinger = _bookingRepo.HentAlleBookinger();
    }
    #endregion
}

