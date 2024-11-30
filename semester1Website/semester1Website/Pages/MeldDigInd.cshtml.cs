using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class MeldDigIndModel : PageModel
    {
        //læs op på bindproperty, virker ikke rigtig uden, men ved ikke hvorfor
        [BindProperty]
        public string MedlemNavn { get; set; }

        [BindProperty]
        public string MedlemMobil { get; set; }

        [BindProperty]
        public string MedlemAddresse { get; set; }

        public Medlem NewMedlem { get; private set; }

        //onpost arbejder sammen med method post fra formen, og trigger på submit
        public void OnPost()
        {
            // Create a new Medlem using the posted data
            NewMedlem = new Medlem(MedlemNavn, MedlemMobil, MedlemAddresse);
            MedlemsRepository.AddMedlem(NewMedlem);
        }
    }
}