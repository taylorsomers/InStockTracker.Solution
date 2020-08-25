﻿// <auto-generated />
using System;
using InStockTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InStockTracker.Migrations
{
    [DbContext(typeof(InStockTrackerContext))]
    [Migration("20200824215823_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("InStockTracker.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Title = "Electronics"
                        });
                });

            modelBuilder.Entity("InStockTracker.Models.CategoryProduct", b =>
                {
                    b.Property<int>("CategoryProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<int>("ProductId");

                    b.HasKey("CategoryProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            CategoryProductId = 1,
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryProductId = 2,
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryProductId = 3,
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryProductId = 4,
                            CategoryId = 1,
                            ProductId = 4
                        });
                });

            modelBuilder.Entity("InStockTracker.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<byte[]>("Img");

                    b.Property<string>("ImgTitle");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Name");

                    b.Property<int>("Stock");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "Logitech webcam",
                            Manufacturer = "Logitech",
                            Name = "Webcam",
                            Stock = 10
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "Razer mechanical keyboard",
                            Manufacturer = "Razer",
                            Name = "Keyboard",
                            Stock = 5
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "Razer gaming mouse",
                            Manufacturer = "Razer",
                            Name = "Mouse",
                            Stock = 6
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "Blue snowball microphone",
                            Manufacturer = "Blue",
                            Name = "Microphone",
                            Stock = 11
                        });
                });

            modelBuilder.Entity("InStockTracker.Models.CategoryProduct", b =>
                {
                    b.HasOne("InStockTracker.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InStockTracker.Models.Product", "Product")
                        .WithMany("Categories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
