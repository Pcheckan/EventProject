using Microsoft.AspNetCore.Mvc;

namespace EventApplication.Model
{
    public class Interests
    {
        [BindProperty]
        public string InterestsCategory { get; set; }
    }
}
