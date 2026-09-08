using Microsoft.EntityFrameworkCore;
using IvanMatveevKT_41_23.Database.Configurations;
using IvanMatveevKT_41_23.Models;

namespace IvanMatveevKT_41_23.Database
{
    public class EducationDbContext : DbContext
    {
        public EducationDbContext(
            DbContextOptions<EducationDbContext> options)
            : base(options)
        {
        }

        public DbSet<AcademicGroup> AcademicGroups { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Credit> Credits { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(
                new AcademicGroupConfiguration());

            modelBuilder.ApplyConfiguration(
                new StudentConfiguration());

            modelBuilder.ApplyConfiguration(
                new SubjectConfiguration());

            modelBuilder.ApplyConfiguration(
                new GradeConfiguration());

            modelBuilder.ApplyConfiguration(
                new CreditConfiguration());
        }
    }
}
