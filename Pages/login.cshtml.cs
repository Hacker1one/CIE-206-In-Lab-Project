using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace InlabProject.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<LoginModel> _logger;

    public LoginModel(ILogger<LoginModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }

    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        // Check if the username and password are correct
        if (Username == "admin" && Password == "admin")
        {
            // Redirect to the home page
            return RedirectToPage("/Home");
        }
        else
        {
            // Display an error message
            ViewData["Error"] = "Invalid username or password";
            return Page();
        }
    }
}