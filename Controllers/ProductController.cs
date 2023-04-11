using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GitTestApp.Controllers
{
   [Route("product")]
   public class ProductController : Controller
   {
      [HttpGet("buy")]
      public ActionResult buy()
      {
         return View();
      }

   }
}
