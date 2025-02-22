using Assignment2E_commerce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Assignment2E_commerce.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public PersonModel? Person { get; set; }

        public void OnGet()
        {
            _logger.LogInformation("Index OnGet");
            if (Person != null)
            {
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Index OnPost");
            if (Person != null)
            {
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
                return RedirectToPage("Privacy", new { name = Person.Name, age = Person.Age });
            }
            return Page();
        }
    }
}
