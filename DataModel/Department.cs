using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Department
    {
        public int Id { get; set; }

        [Display(Name = "Department offering")]
        public string NameEng { get; set; }

        [Display(Name = "Offre du département")]
        public string NameFre { get; set; }

        public int Active { get; set; }

        public List<Course> Courses { get; set; }
    }
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NameEng).IsUnicode(false).HasMaxLength(1000);
            builder.Property(e => e.NameFre).IsUnicode(false).HasMaxLength(1000);
        }
    }
}
