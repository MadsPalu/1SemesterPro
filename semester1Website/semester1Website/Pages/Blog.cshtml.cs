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
    public static void AddEditBlogPost(BlogPostModel blogPost)
    {
        blogPost.Title = "";
        blogPost.ChairMan = "";
        blogPost.Description = "";
        blogPost.ImagePath = "";
        
    }

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

        foreach (var blogPost in EditBlogPost)
        {
            EditBlogPost.Add(blogPost);
        }
        }
    #endregion

    //ny BlogPost objekt
    BlogPost = new BlogPostModel
        {
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

    

