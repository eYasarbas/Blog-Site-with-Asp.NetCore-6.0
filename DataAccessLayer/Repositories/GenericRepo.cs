using System.Linq;
using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class GenericRepo<T> : IGenericDal<T> where T : class
    {
        Context cont = new Context();

        public void Add(T t)
        {
            cont.Add(t);
            cont.SaveChanges();
        }

        public List<T> GetAll()
        {
            return cont.Set<T>().ToList();
        }

        public void Delete(T t)
        {
            cont.Remove(t);
            cont.SaveChanges();
        }

        public T GetByID(int id)
        {
            return cont.Set<T>().Find(id);
        }

        public void Update(T t)
        {
            cont.Update(t);
            cont.SaveChanges();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return cont.Set<T>().Where(filter).ToList();
        }
    }
}