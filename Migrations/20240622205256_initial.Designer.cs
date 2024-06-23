﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Paginas_Enchiladas.DAL;

#nullable disable

namespace Paginas_Enchiladas.Migrations
{
    [DbContext(typeof(TiendaContext))]
    [Migration("20240622205256_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Paginas_Enchiladas.Models.Enchilada", b =>
                {
                    b.Property<int>("id_Enchilada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_Enchilada"));

                    b.Property<float>("Precio")
                        .HasColumnType("real");

                    b.Property<string>("Relleno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Salsa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo_tortilla")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Enchilada");

                    b.ToTable("Enchiladas");
                });
#pragma warning restore 612, 618
        }
    }
}
