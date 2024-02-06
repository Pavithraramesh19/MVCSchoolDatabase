﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolManagementDb.Data;

#nullable disable

namespace SchoolManagementDb.Migrations.ClassesDb
{
    [DbContext(typeof(ClassesDbContext))]
    partial class ClassesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SchoolManagementDb.Models.Classes", b =>
                {
                    b.Property<string>("Standard")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Standard");

                    b.ToTable("Classes");
                });
#pragma warning restore 612, 618
        }
    }
}