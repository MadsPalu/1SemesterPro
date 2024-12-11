using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using semester1Website.Models;

namespace semester1Website.Pages
{
    public class BlogPostModel : PageModel
{
    //giver adgang /wwwroot så man kan gemme billeder/filer
    private readonly IWebHostEnvironment _environment;
    
    
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
    #endregion 

    //Nested BlogPost property, skal bruges til at store data om blogposten
    public BlogPostModel BlogPost { get; set; }

    #region Methods
    public void OnGet()
    {
        BlogPost = new BlogPostModel(); // Undgå null reference
    }

    public IActionResult OnPostEdit()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        if (UploadedImage != null)
        {
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");
            var uniqueFileName = Guid.NewGuid().ToString() + "_" + UploadedImage.FileName;
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                UploadedImage.CopyTo(stream);
            }

            ImagePath = $"/uploads/{uniqueFileName}";
        }
    #endregion

    //ny BlogPost objekt
    BlogPost = new BlogPostModel
        {
            Title = Title,
            ChairMan = ChairMan,
            ImagePath = ImagePath,
            Description = Description
        };

        return Page();
    }
}
}

    

