﻿// <auto-generated />
using System;
using AuctionApp.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AuctionApp.Migrations
{
    [DbContext(typeof(AuctionDbContext))]
    [Migration("20241020101008_3232")]
    partial class _3232
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AuctionApp.Persistence.AuctionDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("AuctionDbs");
                });

            modelBuilder.Entity("AuctionApp.Persistence.BidDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AuctionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BidDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AuctionId");

                    b.ToTable("BidDbs");
                });

            modelBuilder.Entity("AuctionApp.Persistence.BidDb", b =>
                {
                    b.HasOne("AuctionApp.Persistence.AuctionDb", "AuctionDb")
                        .WithMany("BidDbs")
                        .HasForeignKey("AuctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AuctionDb");
                });

            modelBuilder.Entity("AuctionApp.Persistence.AuctionDb", b =>
                {
                    b.Navigation("BidDbs");
                });
#pragma warning restore 612, 618
        }
    }
}