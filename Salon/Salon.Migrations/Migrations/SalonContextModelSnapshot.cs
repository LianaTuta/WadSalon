﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salon.Migrations;

#nullable disable

namespace Salon.Migrations.Migrations
{
    [DbContext(typeof(SalonContext))]
    partial class SalonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Salon.Model.Models.Appoinment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppoinmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AspNetUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUserId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Appoinment");
                });

            modelBuilder.Entity("Salon.Model.Models.SalonModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Salon");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Address 1",
                            Description = "Welcome to Serene Haven Salon & Spa, where tranquility meets transformation. Nestled in the heart of Craiova, our haven offers a serene escape from the hustle and bustle of everyday life. Step into our luxurious sanctuary and embark on a journey of self-care and rejuvenation.\r\n\r\nOur team of skilled professionals is dedicated to providing unparalleled service tailored to your unique needs. Whether you're craving a glamorous makeover, a relaxing massage, or a rejuvenating facial, we have a wide range of services to pamper you from head to toe.",
                            ImagePath = "salon1.jpg",
                            Name = "Serene Haven Salon & Spa"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Address 2",
                            Description = "Welcome to Enchanted Elegance Beauty Lounge, where every visit is a magical experience. Step into our luxurious sanctuary and immerse yourself in a world of enchantment, where beauty meets elegance.\r\n\r\nOur talented team of professionals is dedicated to providing you with top-notch service, tailored to your unique needs and desires. Whether you're seeking a glamorous makeover, a relaxing spa treatment, or expertly styled hair, we have everything you need to enhance your natural beauty and leave you feeling radiant.\r\n\r\nAt Enchanted Elegance, we believe in using only the finest quality products, carefully selected to deliver exceptional results. From luxurious skincare to premium hair care, every detail is designed to pamper you from head to toe and make you feel like royalty.",
                            ImagePath = "salon1.jpg",
                            Name = "Enchanted Beauty Lounge"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Address 3",
                            Description = "Description 3",
                            ImagePath = "salon1.jpg",
                            Name = "Beauty Salon with Name 3"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Address 4",
                            Description = "Description 4",
                            ImagePath = "salon1.jpg",
                            Name = "Beauty Salon with Name 4"
                        });
                });

            modelBuilder.Entity("Salon.Model.Models.SalonService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SalonId");

                    b.ToTable("Service");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description nails",
                            Name = "Gel Nails",
                            SalonId = 3
                        },
                        new
                        {
                            Id = 2,
                            Description = "Descriptions hair",
                            Name = "Hair Treatment",
                            SalonId = 4
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description hair",
                            Name = "Haircut",
                            SalonId = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description gel nails",
                            Name = "Gel Nails",
                            SalonId = 4
                        },
                        new
                        {
                            Id = 5,
                            Description = "Relax and unwind with our signature massage, tailored to soothe muscles and promote deep relaxation.",
                            Name = "Serenity Signature Massage",
                            SalonId = 1
                        },
                        new
                        {
                            Id = 6,
                            Description = "Revive your skin's natural glow with our customized facial, leaving you with a luminous complexion",
                            Name = "Radiance Renewal Facial",
                            SalonId = 1
                        },
                        new
                        {
                            Id = 7,
                            Description = "Pamper your hands and feet with our Fairy Tale Manicure/Pedicure, complete with luxurious treatments and enchanting nail art.",
                            Name = "Fairy Tale Manicure/Pedicure",
                            SalonId = 2
                        },
                        new
                        {
                            Id = 8,
                            Description = "Enhance your features with our Natural Makeup Application, perfect for a subtle yet polished look.",
                            Name = "Natural Makeup Application",
                            SalonId = 2
                        },
                        new
                        {
                            Id = 9,
                            Description = "Nourish your hair with our Nourishing Hair Treatment, restoring health and shine to your locks.",
                            Name = "Nourishing Hair Treatment",
                            SalonId = 2
                        });
                });

            modelBuilder.Entity("Salon.Model.Models.UserAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUserId");

                    b.ToTable("UserAddress");
                });

            modelBuilder.Entity("Salon.Model.Models.UserLogin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserLogin");
                });

            modelBuilder.Entity("Salon.Model.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AspNetUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AspNetUserId");

                    b.ToTable("UserProfile");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Salon.Model.Models.Appoinment", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "AspNetUser")
                        .WithMany()
                        .HasForeignKey("AspNetUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Salon.Model.Models.SalonService", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUser");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Salon.Model.Models.SalonService", b =>
                {
                    b.HasOne("Salon.Model.Models.SalonModel", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Salon.Model.Models.UserAddress", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "AspNetUser")
                        .WithMany()
                        .HasForeignKey("AspNetUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUser");
                });

            modelBuilder.Entity("Salon.Model.Models.UserProfile", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "AspNetUser")
                        .WithMany()
                        .HasForeignKey("AspNetUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AspNetUser");
                });
#pragma warning restore 612, 618
        }
    }
}
