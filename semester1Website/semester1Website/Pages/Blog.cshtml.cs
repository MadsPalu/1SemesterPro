using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class BlogModel : PageModel
    {   

        /*private readonly IWebHostEnvironment _environment;
        public BlogModel (IWebHostEnvironment environment)
        {
            _environment = environment;
        }*/
        
        
        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string ChairMan { get; set; }
        [BindProperty]
        public string ImagePath { get; set; }
        [BindProperty]
        public string Description { get; set; }
        public IFormFile UploadedImage { get; set; }
        
        
        public ChairMan newChairMan { get; set; }
        public void OnPost()
        {
            newChairMan = new ChairMan(1, "Bob");
        }
        
        public IActionResult OnPostEdit(string title, string chairMan, string imagePath, string description)
        {
            Title = title;
            ChairMan = chairMan;
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
        

        
    }
}

    

