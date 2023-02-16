using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IBlogServices : IGenericService<Blog>
    {
        List<Blog> GetBlogListWithCategory();
    }
}