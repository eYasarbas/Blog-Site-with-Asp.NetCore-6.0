using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    [Route("[controller]")]
    public class BlogController : Controller
    {
        private readonly BlogManager bm = new(new EFBlogRepo());
        public IActionResult Index()
        {
            List<EntityLayer.Concrete.Blog> values = bm.GetBlogListWithCategory();
            return View(values);
        }
        [Route("blog/BlogDetails/{id}")]
        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}