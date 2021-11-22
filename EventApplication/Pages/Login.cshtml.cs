using EventApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventApplication.Pages.Shared
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public Login Model { get; set; }
        public void OnGet()
        {
        }
    }
}
