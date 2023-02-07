using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepo : ICategoryDal
    {
        Context cont = new Context();
        public void AddCategory(Category category)
        {
            _ = cont.Add(category);
            _ = cont.SaveChanges();
        }

        public List<Category> AllCategory()
        {
            return cont.Categories.ToList();
        }

        public void DeleteCategory(Category category)
        {
            _ = cont.Remove(category);
            _ = cont.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return cont.Categories.Find(id);
        }

        public void UpdateCategory(Category category)
        {
            _ = cont.Update(category);
            _ = cont.SaveChanges();
        }
    }
}