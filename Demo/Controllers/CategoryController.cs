using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.Controllers
{
    [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly CategoryManager cm = new(new EFCategoryRepo());

        public IActionResult Index()
        {
            List<EntityLayer.Concrete.Category> values = cm.GetAll();
            return View(values);
        }
    }
}