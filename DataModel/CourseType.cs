using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class CourseType
    {
        public int Id { get; set; }
        public string NameEng { get; set; }
        public string NameFre { get; set; }
        public int Active { get; set; }
    }
    public class CourseTypeConfiguration : IEntityTypeConfiguration<CourseType>
    {
        public void Configure(EntityTypeBuilder<CourseType> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NameEng).IsUnicode(false).HasMaxLength(1000);
            builder.Property(e => e.NameFre).IsUnicode(false).HasMaxLength(1000);
        }
    }

}
