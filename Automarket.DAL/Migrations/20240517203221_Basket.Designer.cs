﻿// <auto-generated />
using System;
using Automarket.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Automarket.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240517203221_Basket")]
    partial class Basket
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Automarket.Domain.Entity.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CallBack")
                        .HasColumnType("bit");

                    b.Property<bool>("Checked")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Basket", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Consumable", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ConsumableType")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Subcategory")
                        .HasColumnType("int");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Consumables");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Maintenance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<long?>("AppointmentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CompletionTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stage")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Maintenances");
                });

            modelBuilder.Entity("Automarket.Domain.Entity.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Age = 20,
                            CreationDate = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7269),
                            Email = "secauto.admin@gmail.com",
                            LastLogin = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7305),
                            Lastname = "Linnik",
                            Name = "Vlad",
                            Password = "80e0cae0c86fc08fce7b5c03dd1229078862ab996042db9f4299bd3e838cda2a",
                            Role = 0,
                            Username = "admin"
                        },
                        new
                        {
                            Id = 2L,
                            Age = 20,
                            CreationDate = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7330),
                            Email = "secauto.administrator@gmail.com",
                            LastLogin = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7332),
                            Lastname = "Hranoskyi",
                            Name = "Dimasik",
                            Password = "f301d9014ab4016549a8bf0947644c81f971f79ffa555eb373a3232c71c8f08b",
                            Role = 1,
                            Username = "administrator"
                        },
                        new
                        {
                            Id = 3L,
                            Age = 20,
                            CreationDate = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7371),
                            Email = "secauto.mechanic@gmail.com",
                            LastLogin = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7373),
                            Lastname = "Ishchuk",
                            Name = "Andriy",
                            Password = "7d7401591c213d25d2ca8d65542ca054ecd2fb7ee746094cf4c38acfb42cb744",
                            Role = 2,
                            Username = "mechanic"
                        },
                        new
                        {
                            Id = 4L,
                            Age = 20,
                            CreationDate = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7391),
                            Email = "secauto.testuser@gmail.com",
                            LastLogin = new DateTime(2024, 5, 17, 23, 32, 21, 202, DateTimeKind.Local).AddTicks(7393),
                            Lastname = "User",
                            Name = "Test",
                            Password = "4ace4f0a32ae2bcfece96c5b17c8f74f75c7e2c07a2ce7c6e0deba4553e10f90",
                            Role = 3,
                            Username = "TestUser"
                        });
                });

            modelBuilder.Entity("Automarket.Domain.Entity.Wishlist", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ItemId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Wishlist");
                });
#pragma warning restore 612, 618
        }
    }
}
