﻿// <auto-generated />
using System;
using DetailSample.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DetailSample.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DetailSample.Models.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("State");

                    b.Property<string>("StreetAddress");

                    b.Property<int>("Zip");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DetailSample.Models.InventoryItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemID");

                    b.Property<string>("Name");

                    b.Property<decimal>("PricePerUnit");

                    b.Property<int>("QuantityRemaining");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.HasIndex("ItemID");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("DetailSample.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<DateTime?>("DriverIn");

                    b.Property<DateTime?>("DriverOut");

                    b.Property<int?>("ItemID");

                    b.Property<int>("OrderType");

                    b.Property<decimal>("Price");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("ItemID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DetailSample.Models.OrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("DetailSample.Models.InventoryItem", b =>
                {
                    b.HasOne("DetailSample.Models.InventoryItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID");
                });

            modelBuilder.Entity("DetailSample.Models.Order", b =>
                {
                    b.HasOne("DetailSample.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DetailSample.Models.InventoryItem", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID");
                });
#pragma warning restore 612, 618
        }
    }
}