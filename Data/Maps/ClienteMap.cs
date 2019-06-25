using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mpl.Models;

namespace Mpl.Data.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.ClienteId);
            builder.Property(x => x.Email).IsRequired().HasColumnName("Email").HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.Senha).IsRequired().HasColumnName("Senha").HasMaxLength(21).HasColumnType("varchar(120)");
            builder.Property(x => x.Telefone).HasColumnName("Telefone").HasMaxLength(120).HasColumnType("int");
        }
    }
}