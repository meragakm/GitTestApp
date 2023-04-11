using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GitTestApp.Pages.Product
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
         Console.WriteLine("log");
        }
    }
}
