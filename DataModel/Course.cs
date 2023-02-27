using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Course
    {
        public int Id { get; set; }
        public string Code { get; set; }

        [Display(Name = "Course name")]
        public string TitleEng { get; set; }
        [Display(Name = "Nom du cours")]
        public string TitleFre { get; set; }

        [Display(Name = "Course description")]
        public string DescEng { get; set; }
        [Display(Name = "Description du cours")]
        public string DescFre { get; set; }

        [Display(Name = "Language")]
        public string LangEng { get; set; }
        [Display(Name = "Language")]
        public string LangFre { get; set; }

        [Display(Name = "Total hours")]
        public string Hours { get; set; }

        public int Active { get; set; }

        public int TypeID { get; set; }
        public CourseType CourseType { get; set; }

        public int DepartmentID { get; set; }
        public Department Department { get; set; }

        public int DisciplineID { get; set; }
        public Discipline Discipline { get; set; }
    }
    public class CourseConfiguration :  IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Code).IsUnicode(false).HasMaxLength(50);
            builder.Property(e => e.TitleEng).IsUnicode(false).HasMaxLength(1000);
            builder.Property(e => e.TitleFre).IsUnicode(false).HasMaxLength(1000);
            builder.Property(e => e.DescEng).IsUnicode(false).HasMaxLength(4000);
            builder.Property(e => e.DescFre).IsUnicode(false).HasMaxLength(4000);
            builder.Property(e => e.LangEng).IsUnicode(false).HasMaxLength(100);
            builder.Property(e => e.LangFre).IsUnicode(false).HasMaxLength(100);
            builder.Property(e => e.Hours).IsUnicode(false).HasMaxLength(30);
        }
    }

}
