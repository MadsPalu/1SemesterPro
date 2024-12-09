using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;
namespace semester1Website.Pages
{
    public class BegivenhederModel : PageModel
    {
        
        public string Date { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; } 

        public static void DateTime()
        {
            
        }

        public Event NewEvent { get; private set;}
        public void OnPost()
        {
            NewEvent = new Event(Date, Title, Description, Location);
            Event.AddEvent(NewEvent);
        }
    }
}
