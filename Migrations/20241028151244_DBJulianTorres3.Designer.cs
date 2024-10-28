﻿// <auto-generated />
using System;
using JulianTorres_ExamenP1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JulianTorres_ExamenP1.Migrations
{
    [DbContext(typeof(JulianTorres_ExamenP1Context))]
    [Migration("20241028151244_DBJulianTorres3")]
    partial class DBJulianTorres3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("JulianTorres_ExamenP1.Models.JTTabla", b =>
                {
                    b.Property<int>("JTTablaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JTTablaId"), 1L, 1);

                    b.Property<bool>("JTALaVenta")
                        .HasColumnType("bit");

                    b.Property<float>("JTCostoBruto")
                        .HasColumnType("real");

                    b.Property<string>("JTEmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JTFecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("JTPVP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("JTTablaObjeto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("JTTablaId");

                    b.ToTable("JTTabla");
                });
#pragma warning restore 612, 618
        }
    }
}
