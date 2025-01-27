using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Perforator.Pages
{
    public class PersonalAccountModel : PageModel
    {
        [BindProperty]
        public string Login { get; set; }

        [BindProperty]
        public string Password { get; set; }
        
        
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Логика проверки логина и пароля
            if (IsValidUser(Login, Password))
            {
                return RedirectToPage("Success");
            }
            else
            {
                // Handle invalid login (e.g., show an error message)
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return Page();
            }
        }

        private bool IsValidUser(string login, string password)
        {
            // Implement your user validation logic here
            // For example, check against a database or a predefined list
            return login == "admin" && password == "password"; // Example validation
        }
    }
}