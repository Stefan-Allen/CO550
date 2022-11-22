using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        #pragma warning disable CS8618
        public IndexModel(ILogger<IndexModel> logger)
        #pragma warning restore CS8618
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Anonymous";
        }
        public void OnPost()
        {
            if (string.IsNullOrEmpty(FullName))
            {
                ViewData["Message"] = "You have not entered a name!";
            }
            else
            {
                ViewData["Message"] = "Account is Registered!";
            }
        }
    }
}