﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mpl.Data;

namespace Mpl.Migrations
{
    [DbContext(typeof(StoreDataContext))]
    [Migration("20190610022445_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mpl.Models.Advogado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AreaId");

                    b.Property<int?>("AreasId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("AreasId");

                    b.ToTable("Advogados");
                });

            modelBuilder.Entity("Mpl.Models.Areas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("Mpl.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Mpl.Models.Escritorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AreaId");

                    b.Property<int?>("AreasId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<int>("Telefone");

                    b.HasKey("Id");

                    b.HasIndex("AreasId");

                    b.ToTable("Escritorios");
                });

            modelBuilder.Entity("Mpl.Models.Advogado", b =>
                {
                    b.HasOne("Mpl.Models.Areas")
                        .WithMany("Advogados")
                        .HasForeignKey("AreasId");
                });

            modelBuilder.Entity("Mpl.Models.Escritorio", b =>
                {
                    b.HasOne("Mpl.Models.Areas")
                        .WithMany("Escritorios")
                        .HasForeignKey("AreasId");
                });
#pragma warning restore 612, 618
        }
    }
}
