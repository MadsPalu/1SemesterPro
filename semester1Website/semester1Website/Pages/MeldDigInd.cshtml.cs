using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class MeldDigIndModel : PageModel
    {
        #region Properties
        [BindProperty]
        public string MedlemName { get; set; }

        [BindProperty]
        public string MedlemMobil { get; set; }

        [BindProperty]
        public string MedlemAddresse { get; set; }

        public Member NewMedlem { get; private set; }
        #endregion

        #region Methods
        //onpost arbejder sammen med method post fra formen, og trigger p� submit
        public void OnPost()
        {
            NewMedlem = new Member(MedlemName, MedlemMobil, MedlemAddresse);
            RepoInitializer.memberRepo.Add(NewMedlem);
        }
        #endregion
    }
}