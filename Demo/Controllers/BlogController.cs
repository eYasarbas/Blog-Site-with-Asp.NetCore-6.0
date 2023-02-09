using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    [Route("[controller]")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}