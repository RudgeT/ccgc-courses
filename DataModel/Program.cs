using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace DataModel
{
    public class Program
    {
        public int Id { get; set; }

        [Display(Name = "Program code")]
        public string CodeEng { get; set; }
        [Display(Name = "Code du programme")]
        public string CodeFre { get; set; }

        [Display(Name = "Program name")]
        public string NameEng { get; set; }
        [Display(Name = "Nom du programme")]
        public string NameFre { get; set; }

        public int Active { get; set; }
    }

    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.CodeEng).IsUnicode(false).HasMaxLength(50);
            builder.Property(e => e.CodeFre).IsUnicode(false).HasMaxLength(50);
            builder.Property(e => e.NameEng).IsUnicode(false).HasMaxLength(1000);
            builder.Property(e => e.NameFre).IsUnicode(false).HasMaxLength(1000);
        }
    }
}
