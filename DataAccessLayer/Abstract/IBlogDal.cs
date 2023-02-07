using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal
    {
        List<Blog> AllBlog();
        void AddBlog(Blog blog);
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);

        Blog GetByID(int id);
    }
}