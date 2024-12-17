using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semester1Website.Pages
{
    public class IndexModel : PageModel
    {
        #region Instance Fields
        private readonly ILogger<IndexModel> _logger;
        #endregion
        #region Constructors
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        #endregion

        #region Methods
        public void OnGet()
        {

        }
        #endregion
    }
}
