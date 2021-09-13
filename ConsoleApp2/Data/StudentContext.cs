using ConsoleApp2.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp2.Data
{
    public class StudentContext : DbContext
    {
        public DbSet<Student>? Students { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>()
                .OwnsOne(w => w.Name);
        }
    }
}
