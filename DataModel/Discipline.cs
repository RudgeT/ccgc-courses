using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Discipline
    {
        public int Id { get; set; }

        [Display(Name = "Discipline receiving")]
        public string NameEng { get; set; }

        [Display(Name = "Discipline recevant")]
        public string NameFre { get; set; }

        public int Active { get; set; }
    }
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.NameEng).IsUnicode(false).HasMaxLength(1000);
            builder.Property(e => e.NameFre).IsUnicode(false).HasMaxLength(1000);
        }
    }
}
