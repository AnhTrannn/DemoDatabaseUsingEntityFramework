﻿// <auto-generated />
using System;
using DemoDatabaseUsingEntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoDatabaseUsingEntityFramework.Migrations
{
    [DbContext(typeof(MyStoreContext))]
    partial class MyStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DemoDatabaseUsingEntityFramework.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CategoryId")
                        .HasName("PK__Category__19093A2BF606924E");

                    b.ToTable("Category", (string)null);
                });

            modelBuilder.Entity("DemoDatabaseUsingEntityFramework.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CategoryID");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductId")
                        .HasName("PK__Product__B40CC6EDDAD2C0C9");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("DemoDatabaseUsingEntityFramework.Models.Product", b =>
                {
                    b.HasOne("DemoDatabaseUsingEntityFramework.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("FK__Product__Categor__4BAC3F29");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DemoDatabaseUsingEntityFramework.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
