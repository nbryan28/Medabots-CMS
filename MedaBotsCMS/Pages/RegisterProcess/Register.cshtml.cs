using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedaBotsCMS.Pages
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }


        public IActionResult OnPostNextRegister()
        {
            return Redirect("/Privacy");
        }

    }
}
