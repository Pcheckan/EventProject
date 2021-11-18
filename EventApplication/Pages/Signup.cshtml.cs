using EventApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventApplication.Pages
{
    public class SignupModel : PageModel
    {
        public Register Model { get; set; }
        public void OnGet()
        {
        }
        // https://www.learnrazorpages.com/razor-pages/model-binding

    }
}
