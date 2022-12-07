using System;
using System.Collections.Generic;
using System.Text;
using CCG.AspNetCore.Data.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataModel.Configurations
{
    public class YearLevelLevelConfiguration : IEntityTypeConfiguration<YearLevel>
    {
        public void Configure(EntityTypeBuilder<YearLevel> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(b => b.LevelValue)
                .IsRequired()
            .HasMaxLength(50);

            builder.Property(b => b.Active)
               .IsRequired();
        }
    }
}
