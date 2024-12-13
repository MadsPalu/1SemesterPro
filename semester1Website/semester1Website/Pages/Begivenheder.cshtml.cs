using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;
namespace semester1Website.Pages
{
    public class BegivenhederModel : PageModel
    {
        #region Properties
        [BindProperty]
        public string Date { get; set; } 
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Description { get; set; }
        [BindProperty]
        public string Location { get; set; } 
        #endregion

        public List<string> Locations { get; private set; } = new List<string>
        {
            "København",
            "Hillerød"
        };
        public Event NewEvent { get; private set;}
        public void OnPost()
        {
            NewEvent = new Event(Date, Title, Description, Location);
            Event.AddEvent(NewEvent);
        }
    }
}
