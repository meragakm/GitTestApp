using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GitTestApp.Controllers
{
   [Route("product")]
   [ApiController]
   public class ProductController : ControllerBase
   {
      [HttpGet]
      public ActionResult index()
      {
         return Ok(1);
      }

   }
}
