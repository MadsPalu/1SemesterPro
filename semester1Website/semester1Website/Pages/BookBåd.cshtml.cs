using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class BookBådModel : PageModel
    {
        // List of available båd types
        public List<string> BådTyper { get; private set; } = new List<string>
        {
            "Motorbåd",
            "Sejlbåd",
            "Robåd"
        };

        // Selected båd type from dropdown
        [BindProperty]
        public string ValgtBådType { get; set; }

        //Generale båd værdier
        [BindProperty]
        public string BådNavn { get; set; }

        [BindProperty]
        public string BådModel { get; set; }

        [BindProperty]
        public int BådByggeÅr { get; set; }

        [BindProperty]
        public string BådMål { get; set; }

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

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(ValgtBådType))
            {
                switch (ValgtBådType)
                {
                    case "Motorbåd":
                        MotorBåd motorBåd = new MotorBåd(BådNavn, BådModel, BådByggeÅr, BådMål, Motor, Hæstekrafter, Liter);
                        BådRepository.AddBåd(motorBåd);
                        break;
                    case "Sejlbåd":
                        SejlBåd sejlBåd = new SejlBåd(BådNavn, BådModel, BådByggeÅr, BådMål, AntalSejl, MaksSejlBredde);
                        BådRepository.AddBåd(sejlBåd);
                        break;
                    case "Robåd":
                        RoBåd roBåd = new RoBåd(BådNavn, BådModel, BådByggeÅr, BådMål, SiddePladser, AntalÅrer);
                        BådRepository.AddBåd(roBåd);
                        break;
                }
            }
        }
    }
}