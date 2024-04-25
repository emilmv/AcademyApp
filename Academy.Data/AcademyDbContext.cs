using Academy.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Academy.Data
{
    public class AcademyDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-PJER2FH7OJN;Database=AcademyApp;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;");
        }
    }
}
