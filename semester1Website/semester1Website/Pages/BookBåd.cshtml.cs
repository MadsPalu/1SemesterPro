using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class BookBådModel : PageModel
    {
        #region Properties
        //List af både
        public List<string> boatTyper { get; private set; } = new List<string>
        {
            "Motorbåd",
            "Sejlbåd",
            "Robåd"
        };

        // Selected båd type from dropdown
        [BindProperty]
        public string ValgtboatType { get; set; }

        //Generale båd værdier
        [BindProperty]
        public string Bådname { get; set; }

        [BindProperty]
        public string BådModel { get; set; }

        [BindProperty]
        public int BådbuildYear { get; set; }

        [BindProperty]
        public string Båddimensions { get; set; }

        //Motorbåd værdier
        [BindProperty]
        public string Motor { get; set; }

        [BindProperty]
        public int Hæstekrafter { get; set; }

        [BindProperty]
        public double Liter { get; set; }

        //Sejlbåd værdier
        [BindProperty]
        public int AntalSejl { get; set; }

        [BindProperty]
        public double MaksSejlBredde { get; set; }

        //Robåd værdier
        [BindProperty]
        public int SiddePladser { get; set; }

        [BindProperty]
        public int AntalÅrer { get; set; }
        #endregion 


        #region Methods
        public void OnPost()
        {
            if (!string.IsNullOrEmpty(ValgtboatType))
            {
                switch (ValgtboatType)
                {
                    case "Motorbåd":
                        MotorBoat motorBåd = new MotorBoat(Bådname, BådModel, BådbuildYear, Båddimensions, Motor, Hæstekrafter, Liter);
                        RepoinItialiser.boatRepo.Add(motorBåd);
                        break;
                    case "Sejlbåd":
                        SailBoat sejlBåd = new SailBoat(Bådname, BådModel, BådbuildYear, Båddimensions, AntalSejl, MaksSejlBredde);
                        RepoinItialiser.boatRepo.Add(sejlBåd);
                        break;
                    case "Robåd":
                        RowBoat roBåd = new RowBoat(Bådname, BådModel, BådbuildYear, Båddimensions, SiddePladser, AntalÅrer);
                        RepoinItialiser.boatRepo.Add(roBåd);
                        break;
                }
            }
        }
        #endregion
    }
}