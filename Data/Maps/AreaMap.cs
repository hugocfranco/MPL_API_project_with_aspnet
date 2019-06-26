using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mpl.Models;

namespace Mpl.Data.Maps
{
    public class AreaMap : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> builder)
        {
            builder.ToTable("Area");
            builder.HasKey(x => x.AreaId);
            builder.Property(x => x.Descricao)
                .IsRequired().HasColumnName("Descrição")
                .HasMaxLength(120)
                .HasColumnType("varchar(120)");
        }
    }
}