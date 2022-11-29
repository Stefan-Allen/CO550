using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;


namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]

        public string? x { get; set; }
        double result;

        public void OnPost()
        {
            if (!String.IsNullOrWhiteSpace(x))
            {
                result = Convert.ToDouble(x) * 1.21;
                ViewData["Message"] = $"£{x} Is ${result}";
            }

        }
    }
}