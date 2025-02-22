using Assignment2E_commerce.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Assignment2E_commerce.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public PersonModel? Person { get; set; }

        public void OnGet(string? name, int? age)
        {
            _logger.LogInformation("Privacy OnGet");
            if (!string.IsNullOrEmpty(name) && age.HasValue)
            {
                Person = new PersonModel { Name = name, Age = age.Value };
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }

        public void OnPost()
        {
            _logger.LogInformation("Privacy OnPost");
            if (Person != null)
            {
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }
    }
}
