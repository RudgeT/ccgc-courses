using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class CourseTypeConfiguration : IEntityTypeConfiguration<CourseType>
    {

        public void Configure(EntityTypeBuilder<CourseType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.NameEng)
            .HasMaxLength(1000);
            builder.Property(b => b.NameFre)
            .HasMaxLength(1000);
            builder.Property(b => b.Active)
                .IsRequired();

        }
    }
}