using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventApplication.Pages
{
    public class SignupModel : PageModel
    {

        public void OnGet()
        {
        }
        public void OnPost()
        {
            var firstname = Request.Form["firstName"];
            var lastName = Request.Form["lastName"];
            ViewData["confirmation"] = $"{firstname} {lastName}";
        }
    }
}
