using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semester1Website.Pages
{
    public class BlogModel : PageModel
    {   

        private readonly IWebHostEnvironment _environment;
        public BlogModel (IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string FormandNavn { get; set; }
        [BindProperty]
        public string ImagePath { get; set; }
        [BindProperty]
        public string Description { get; set; }
        public IFormFile UploadedImage { get; set; }
        
        /* Skal vist lige have lavet en class til Formand :=)
        public Formand NewFormand { get; set; }
    
        public void OnPost()
        {
            NewFormand = new Formand(FormandNavn);
            FormandNavnsRepository.AddFormand(NewFormand);
        }*/
        
        public IActionResult OnPostEdit(string title, string formandNavn, string imagePath, string description)
        {
            Title = title;
            FormandNavn = formandNavn;
            ImagePath = imagePath;
            Description = description;
            return Page();
        }

        


        /* Det her er totalt fra chatten, men der står man gerne skulle kunne uploade et billede :D
        public async Task<IActionResult> OnPostUploadAsync()
        {
            if (UploadedImage != null && UploadedImage.Length > 0)
            {
                var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
                var uniqueFileName = Guid.NewGuid().ToString() + "_" + UploadedImage.FileName;
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await UploadedImage.CopyToAsync(fileStream);
                }

                ImagePath = "/uploads/" + uniqueFileName;
            }
            return Page();
        }
        */
        

        /* ved ikke ligeee hvordan man skal gøre så man skal logge ind for at skrive, men tænker det noget i denne retning
        public BlogModel(string CurrentUser)
        {
            if(CurrentUser != ChairmanName)
            {
                Console.WriteLine("Du kan ikke redigere");
            }
        }   */
    }
}

    

