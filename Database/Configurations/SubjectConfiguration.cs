using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using IvanMatveevKT_41_23.Models;

namespace IvanMatveevKT_41_23.Database.Configurations
{
    public class SubjectConfiguration
        : IEntityTypeConfiguration<Subject>
    {
        public void Configure(
            EntityTypeBuilder<Subject> builder)
        {
            builder.ToTable("subjects");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(150);

            builder.Property(x => x.Direction)
                .HasConversion<string>()
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.IsDeleted)
                .HasDefaultValue(false);

            builder.HasIndex(x => x.Name);
        }
    }
}
