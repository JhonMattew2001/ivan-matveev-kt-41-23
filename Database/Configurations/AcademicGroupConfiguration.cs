using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IvanMatveevKT_41_23.Models;

namespace IvanMatveevKT_41_23.Database.Configurations
{
    public class AcademicGroupConfiguration
        : IEntityTypeConfiguration<AcademicGroup>
    {
        public void Configure(
            EntityTypeBuilder<AcademicGroup> builder)
        {
            builder.ToTable("academic_groups");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.GroupName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(x => x.Specialty)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Year)
                .IsRequired();

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasIndex(x => x.GroupName);

            builder.HasMany(x => x.Students)
                .WithOne(x => x.Group)
                .HasForeignKey(x => x.GroupId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
