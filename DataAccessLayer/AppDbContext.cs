using Microsoft.EntityFrameworkCore;
using Practice.Models;

namespace Practice.DataAccessLayer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<Course> courses { get; set; }
    }
}
