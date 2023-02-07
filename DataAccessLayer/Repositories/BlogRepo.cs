using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class BlogRepo : IBlogDal
    {
        Context cont = new Context();

        public void AddBlog(Blog blog)
        {
            _ = cont.Add(blog);
            _ = cont.SaveChanges();
        }

        public List<Blog> AllBlog()
        {
            return cont.Blogs.ToList();
        }

        public void DeleteBlog(Blog blog)
        {
            _ = cont.Remove(blog);
            _ = cont.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            return cont.Blogs.Find(id);
        }

        public void UpdateBlog(Blog blog)
        {
            _ = cont.Update(blog);
            _ = cont.SaveChanges();
        }

    }
}