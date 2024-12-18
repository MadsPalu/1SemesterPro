using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace semester1Website.Pages
{
    public class PrivacyModel : PageModel
    {
        #region Instance Fields
        private readonly ILogger<PrivacyModel> _logger;
        #endregion

        #region Constructors
        public PrivacyModel(ILogger<PrivacyModel> logger)
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
