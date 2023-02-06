using Microsoft.EntityFrameworkCore;
using EntityLayer;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            _ = optionsBuilder.UseSqlServer("server=DESKTOP-CA5C4BN; database=BlogDb; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
    }
}