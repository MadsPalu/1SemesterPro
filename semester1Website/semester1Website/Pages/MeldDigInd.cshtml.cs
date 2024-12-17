using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class MeldDigIndModel : PageModel
    {
        //l�s op p� bindproperty, virker ikke rigtig uden, men ved ikke hvorfor
        [BindProperty]
        public string MedlemName { get; set; }

        [BindProperty]
        public string MedlemMobil { get; set; }

        [BindProperty]
        public string MedlemAddresse { get; set; }

        public Member NewMedlem { get; private set; }

        //onpost arbejder sammen med method post fra formen, og trigger p� submit
        public void OnPost()
        {
            NewMedlem = new Member(MedlemName, MedlemMobil, MedlemAddresse);
            RepoinItialiser.memberRepo.Add(NewMedlem);
        }
    }
}