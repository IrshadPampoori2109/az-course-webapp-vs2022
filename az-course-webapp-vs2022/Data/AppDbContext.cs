using Microsoft.EntityFrameworkCore;

namespace az_course_webapp_vs2022.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        public DbSet<Person> Persons { get; set; }
    }
}
