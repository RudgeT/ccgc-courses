using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {

        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.Code)
                .HasMaxLength(50);
            builder.Property(b => b.TitleEng)
            .HasMaxLength(1000);
            builder.Property(b => b.TitleFre)
            .HasMaxLength(1000);
            builder.Property(b => b.DescEng)
                .HasMaxLength(4000);
            builder.Property(b => b.DescFre)
            .HasMaxLength(4000);
            builder.Property(b => b.LangEng)
                .HasMaxLength(100);
            builder.Property(b => b.LangFre)
            .HasMaxLength(100);
            builder.Property(b => b.Hours)
                .HasMaxLength(30);
            builder.Property(b => b.Active)
                .IsRequired();

        }
    }
}
