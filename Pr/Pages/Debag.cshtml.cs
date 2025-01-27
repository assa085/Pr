using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Perforator.CustomClasses;

namespace Pr.Pages
{
    public class DebagModel : PageModel
    {
        public IEnumerable<User> Users { get; set; }
        public void OnGet()
        {
            if(RegistrationModel.usersList.Count != 0)
            {
                Users = RegistrationModel.usersList.ToList();

            }
            else
            {
                Users = new List<User>().ToArray();
            }
        }
    }
}
