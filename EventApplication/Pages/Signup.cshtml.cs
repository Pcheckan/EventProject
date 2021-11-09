using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventApplication.Pages
{
    public class SignupModel : PageModel
    {

        public void OnGet()
        {
        }
        // https://www.learnrazorpages.com/razor-pages/model-binding
        public void OnPost()
        {
            var firstname = Request.Form["firstName"];
            var lastName = Request.Form["lastName"];
            var gender = Request.Form["gender"];
            ViewData["confirmation"] = $"{firstname} {lastName} , {gender}";
        }
    }
}
