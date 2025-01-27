using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Perforator.CustomClasses;

public class RegistrationModel : PageModel
{
    public static  List<User> usersList = new List<User>();

    public void OnGet()
    {
        // ������ ��� GET-�������, ���� ����������
    }

    [BindProperty]
    public User User { get; set; } // �������� BindProperty �������

    public IActionResult OnPost()
    {
        try
        {
            if (User == null ||
                string.IsNullOrEmpty(User.Name) ||
                string.IsNullOrEmpty(User.Password))
            {
                return BadRequest(new { success = false, message = "Invalid data." });
            }

            usersList.Add(User);
            Console.WriteLine($"User added: {User.Name}");

            return new JsonResult(new { success = true });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return StatusCode(500, new { success = false, message = ex.Message });
        }
    }

}


