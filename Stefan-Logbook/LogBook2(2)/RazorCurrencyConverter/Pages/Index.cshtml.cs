using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;


namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]

        public string? x { get; set; }
        public const double y = 1.21;
        double result;

        public void OnPost()
        {
            if (!String.IsNullOrWhiteSpace(x))
            {
                result = Convert.ToDouble(x) * y;
                ViewData["Message"] = $"£{x} Is ${result}";
            }

        }
    }
}