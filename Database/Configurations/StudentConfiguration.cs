using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IvanMatveevKT_41_23.Models;

namespace IvanMatveevKT_41_23.Database.Configurations
{
    public class StudentConfiguration
        : IEntityTypeConfiguration<Student>
    {
        public void Configure(
            EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("students");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.MiddleName)
                .HasMaxLength(100);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasIndex(x => x.GroupId);
            builder.HasIndex(x => x.LastName);
        }
    }
}
