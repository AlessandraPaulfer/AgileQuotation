﻿// <auto-generated />
using System;
using AgileQuotation.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgileQuotation.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240409112826_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("AgileQuotation.API.Models.ProductSupplier", b =>
                {
                    b.Property<int>("ProductSupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BoardingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Brand")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("CountBySKU")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Group")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastMonthValidate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LastPurchase")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastSupplier")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("LastValidate")
                        .HasColumnType("TEXT");

                    b.Property<int>("SKU")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusProduct")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SubBrand")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubGroup")
                        .HasColumnType("TEXT");

                    b.Property<int>("TypeIndAtac")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeSKUPositive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeSituation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TypeUnit")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("UnitBox")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Weigth")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductSupplierId");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("AgileQuotation.API.Models.QuotationSupplier", b =>
                {
                    b.Property<int>("QuotationSupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ProductSupplierId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("State")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StatusSupplier")
                        .HasColumnType("INTEGER");

                    b.HasKey("QuotationSupplierId");

                    b.HasIndex("ProductSupplierId");

                    b.ToTable("QuotationSupplier");
                });

            modelBuilder.Entity("AgileQuotation.API.Models.QuotationSupplier", b =>
                {
                    b.HasOne("AgileQuotation.API.Models.ProductSupplier", null)
                        .WithMany("QuotationSupplier")
                        .HasForeignKey("ProductSupplierId");
                });

            modelBuilder.Entity("AgileQuotation.API.Models.ProductSupplier", b =>
                {
                    b.Navigation("QuotationSupplier");
                });
#pragma warning restore 612, 618
        }
    }
}