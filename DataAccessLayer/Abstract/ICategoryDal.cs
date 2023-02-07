using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        List<Category> AllCategory();
        void AddCategory(Category category);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);

        Category GetByID(int id);
    }
}