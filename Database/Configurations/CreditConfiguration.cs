using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IvanMatveevKT_41_23.Models;

namespace IvanMatveevKT_41_23.Database.Configurations
{
    public class CreditConfiguration
        : IEntityTypeConfiguration<Credit>
    {
        public void Configure(
            EntityTypeBuilder<Credit> builder)
        {
            builder.ToTable("credits");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.IsPassed)
                .IsRequired();

            builder.Property(x => x.AcademicYear)
                .IsRequired();

            builder.HasOne(x => x.Student)
                .WithMany(x => x.Credits)
                .HasForeignKey(x => x.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Subject)
                .WithMany(x => x.Credits)
                .HasForeignKey(x => x.SubjectId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasIndex(x => x.StudentId);
            builder.HasIndex(x => x.SubjectId);
        }
    }
}
