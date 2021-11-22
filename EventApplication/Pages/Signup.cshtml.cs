using EventApplication.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;

namespace EventApplication.Pages
{
    public class SignupModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        [BindProperty]
        public Register Model { get; set; }
     
        public SignupModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        
        
        
        public void OnGet()
        {
        }
        // https://www.learnrazorpages.com/razor-pages/model-binding

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email,

                };

                var result = await userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);

                    SqlConnection conn = new SqlConnection("Data Source=eventapplication-server.database.windows.net;Initial Catalog=eventapplication-database;Persist Security Info=True;User ID=eventapplication-server-admin;Password=WebAppPassword!@#");
                    {
                        SqlCommand insert = new SqlCommand("EXEC dbo.CreateNewUser @firstName, @lastName, @gender, @phoneNumber, @DOB, @Interest1, @Interest2, @Interest3", conn);
                        insert.Parameters.AddWithValue("@firstName", Model.firstName);
                        insert.Parameters.AddWithValue("@lastName", Model.lastName);
                        insert.Parameters.AddWithValue("@gender", Model.Gender);
                        insert.Parameters.AddWithValue("@phoneNumber", Model.phoneNumber);
                        insert.Parameters.AddWithValue("@DOB", Model.dateOfBirth);
                        insert.Parameters.AddWithValue("@interest1", Model.interestOne);
                        insert.Parameters.AddWithValue("@interest2", Model.interestTwo);
                        insert.Parameters.AddWithValue("@interest3", Model.interestThree);

                        conn.Open();
                        insert.ExecuteNonQuery();
                        conn.Close();

                    }
                    return RedirectToPage("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();
        }
    }
}
