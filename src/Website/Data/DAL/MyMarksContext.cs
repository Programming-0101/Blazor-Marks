using Microsoft.EntityFrameworkCore;
using WebApp.Data.Models;

namespace WebApp.Data.DAL
{
    public class MyMarksContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public MyMarksContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("MyDb"));
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<EvaluationItem> EvaluationItems { get; set; }
        public DbSet<EvaluationGroup> EvaluationGroups { get; set; }
    }
}
