using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class ProgramConfiguration : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(b => b.CodeEng)
                .HasMaxLength(50);
            builder.Property(b => b.CodeFre)
                .HasMaxLength(50);
            builder.Property(b => b.NameEng)
            .HasMaxLength(1000);
            builder.Property(b => b.NameFre)
            .HasMaxLength(1000);
            builder.Property(b => b.Active)
                .IsRequired();

        }
    }
}
