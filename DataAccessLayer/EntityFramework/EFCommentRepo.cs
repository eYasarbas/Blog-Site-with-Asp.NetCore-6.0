using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentRepo : GenericRepo<Comment>, ICommentDal
    {
    }
}