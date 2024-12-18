using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class BlogPostModel : PageModel
{
    #region Instance Fields
    //giver adgang /wwwroot så man kan gemme billeder/filer
    private readonly IWebHostEnvironment _environment;
    #endregion

    #region Properties
    [BindProperty]
    public string Title { get; set; }

    [BindProperty]
    public string ChairMan { get; set; }

    [BindProperty]
    public IFormFile UploadedImage { get; set; }

    [BindProperty]
    public string Description { get; set; }
    public string ImagePath { get; set; }
    public int Id { get; set; }
    //Nested BlogPost property, skal bruges til at store data om blogposten
    public BlogPostModel BlogPost { get; set; }
    public static List<Event> EditBlogPost { get; set; } = new List<Event>(); 
    #endregion 

    #region Methods
    
    public void OnGet()
    {
        
    }

    public IActionResult OnPostEdit()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (UploadedImage != null)
        {
            //Bestemmer uploadede filens sti ved at kombinere webroot med "uploads"
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
            //Genererer en unik filnavn ved at tilføje et unikt ID og navn til den uploadede fil.
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + UploadedImage.FileName;
            //Opretter filsti hvor filen gemmes.
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                UploadedImage.CopyTo(stream);
            }

            ImagePath = $"/uploads/{uniqueFileName}";
        }

    //ny BlogPost objekt
    BlogPost = new BlogPostModel
        {
            Id = Id,
            Title = Title,
            ChairMan = ChairMan,
            ImagePath = ImagePath,
            Description = Description,
        };

        return Page();
        #endregion
    }
}
}

    

