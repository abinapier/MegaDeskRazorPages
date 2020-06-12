﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDesk.Migrations
{
    [DbContext(typeof(MegaDeskContext))]
    [Migration("20200611192514_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("MegaDesk.Models.Quote", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("TEXT");

                    b.Property<int>("DeskDepth")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DeskQuote")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("DeskSurfaceMaterial")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeskWidth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DrawerCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrderTime")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("Quote");
                });
#pragma warning restore 612, 618
        }
    }
}