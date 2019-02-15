using System.Collections.Generic;
using System.Data.Entity;

namespace CodeFirst
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }
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
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
