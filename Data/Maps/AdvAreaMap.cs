using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mpl.Models;

namespace Mpl.Data.Maps
{
    public class AdvAreaMap: IEntityTypeConfiguration<AdvArea>
    {
        public void Configure(EntityTypeBuilder<AdvArea> builder)
        {
            builder.ToTable("AdvArea");
            builder.HasKey(x => new {x.AdvogadoId, x.AreaId});
        }

    }
}