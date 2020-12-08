﻿// <auto-generated />
using AspNetHomework.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AspNetHomework.Database.Migrations
{
    [DbContext(typeof(AspNetHomeworkContext))]
    [Migration("20201208104703_FixAvailab")]
    partial class FixAvailab
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AspNetHomework.Database.Domain.Availability", b =>
                {
                    b.Property<long>("Entity1Id")
                        .HasColumnType("bigint")
                        .HasColumnName("ProductId");

                    b.Property<long>("Entity2Id")
                        .HasColumnType("bigint")
                        .HasColumnName("ShopId");

                    b.Property<long>("Count")
                        .HasColumnType("bigint");

                    b.HasKey("Entity1Id", "Entity2Id");

                    b.HasIndex("Entity2Id");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("AspNetHomework.Database.Domain.Shop", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("ShopName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("AspNetHomework.Database.Domain.Vendor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("AspNetHomework.Database.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<string>("VendorCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("VendorId")
                        .HasColumnType("bigint");

                    b.Property<double>("Weight")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AspNetHomework.Database.Domain.Availability", b =>
                {
                    b.HasOne("AspNetHomework.Database.Product", "Entity1")
                        .WithMany("Availabilities")
                        .HasForeignKey("Entity1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AspNetHomework.Database.Domain.Shop", "Entity2")
                        .WithMany("Availabilities")
                        .HasForeignKey("Entity2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity1");

                    b.Navigation("Entity2");
                });

            modelBuilder.Entity("AspNetHomework.Database.Product", b =>
                {
                    b.HasOne("AspNetHomework.Database.Domain.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("AspNetHomework.Database.Domain.Shop", b =>
                {
                    b.Navigation("Availabilities");
                });

            modelBuilder.Entity("AspNetHomework.Database.Product", b =>
                {
                    b.Navigation("Availabilities");
                });
#pragma warning restore 612, 618
        }
    }
}
