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
        public IActionResult BlogReadAll(int id)
        {
            EntityLayer.Concrete.Blog values = bm.GetByID(id);
            return View(values);
        }
    }
}