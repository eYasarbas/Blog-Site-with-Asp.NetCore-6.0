using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EFBlogRepo : GenericRepo<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using Context c = new Context();
            return c.Blogs.Include(x => x.Category).ToList();
        }
    }
}