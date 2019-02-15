using System.Data.Entity;

namespace CodeFirst
{
    public class PlutoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public PlutoContext()
            : base("name= DefaultConnection")
        {

        }
    }
}
