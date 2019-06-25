using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mpl.Models;

namespace Mpl.Data.Maps
{
    public class EscAreaMap: IEntityTypeConfiguration<EscArea>
    {
        public void Configure(EntityTypeBuilder<EscArea> builder)
        {
            builder.ToTable("EscArea");
            builder.HasKey(x => new {x.EscritorioId, x.AreaId});
        }

    }
}