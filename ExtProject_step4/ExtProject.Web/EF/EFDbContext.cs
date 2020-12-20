using System.Data.Entity;
using ExtProject.Web.EF.Initialize;
using ExtProject.Web.Models;

namespace ExtProject.Web.EF
{
    public class EFDbContext : DbContext
    {
        static EFDbContext()
        {
            Database.SetInitializer<EFDbContext>(new ArchiveDbInitializer());
        }

        public EFDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}