﻿// <auto-generated />
using System;
using Lab04.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab04.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211016010942_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Lab04.Models.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Population")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.HasKey("CityID");

                    b.HasIndex("ProvinceCode");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            CityName = "Edmonton",
                            Population = 165121,
                            ProvinceCode = "AB"
                        },
                        new
                        {
                            CityID = 2,
                            CityName = "Calgary",
                            Population = 135234,
                            ProvinceCode = "AB"
                        },
                        new
                        {
                            CityID = 3,
                            CityName = "Victoria",
                            Population = 18951,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityID = 4,
                            CityName = "Vancouver",
                            Population = 244895,
                            ProvinceCode = "BC"
                        },
                        new
                        {
                            CityID = 5,
                            CityName = "Winnipeg",
                            Population = 83155,
                            ProvinceCode = "MB"
                        },
                        new
                        {
                            CityID = 6,
                            CityName = "Fredericton",
                            Population = 18623,
                            ProvinceCode = "NB"
                        },
                        new
                        {
                            CityID = 7,
                            CityName = "Moncton",
                            Population = 1816513,
                            ProvinceCode = "NB"
                        },
                        new
                        {
                            CityID = 8,
                            CityName = "St.John's",
                            Population = 48913,
                            ProvinceCode = "NL"
                        },
                        new
                        {
                            CityID = 9,
                            CityName = "Halifax",
                            Population = 498564,
                            ProvinceCode = "NS"
                        },
                        new
                        {
                            CityID = 10,
                            CityName = "Toronto",
                            Population = 849156,
                            ProvinceCode = "ON"
                        },
                        new
                        {
                            CityID = 11,
                            CityName = "Charlottetown",
                            Population = 198137,
                            ProvinceCode = "PE"
                        },
                        new
                        {
                            CityID = 12,
                            CityName = "Quebec City",
                            Population = 908465,
                            ProvinceCode = "QC"
                        },
                        new
                        {
                            CityID = 13,
                            CityName = "Regina",
                            Population = 4442879,
                            ProvinceCode = "SK"
                        },
                        new
                        {
                            CityID = 14,
                            CityName = "Saskatoon",
                            Population = 716129,
                            ProvinceCode = "SK"
                        });
                });

            modelBuilder.Entity("Lab04.Models.Province", b =>
                {
                    b.Property<string>("ProvinceCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProvinceCode");

                    b.ToTable("Province");

                    b.HasData(
                        new
                        {
                            ProvinceCode = "AB",
                            ProvinceName = "Alberta"
                        },
                        new
                        {
                            ProvinceCode = "BC",
                            ProvinceName = "British Columbia"
                        },
                        new
                        {
                            ProvinceCode = "MB",
                            ProvinceName = "Manitoba"
                        },
                        new
                        {
                            ProvinceCode = "NB",
                            ProvinceName = "New Brunswick"
                        },
                        new
                        {
                            ProvinceCode = "NL",
                            ProvinceName = "Newfoundland"
                        },
                        new
                        {
                            ProvinceCode = "NS",
                            ProvinceName = "Nova Scotia"
                        },
                        new
                        {
                            ProvinceCode = "ON",
                            ProvinceName = "Ontario"
                        },
                        new
                        {
                            ProvinceCode = "PE",
                            ProvinceName = "Prince Edward Island"
                        },
                        new
                        {
                            ProvinceCode = "QC",
                            ProvinceName = "Quebec"
                        },
                        new
                        {
                            ProvinceCode = "SK",
                            ProvinceName = "Saskatchewan"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Lab04.Models.City", b =>
                {
                    b.HasOne("Lab04.Models.Province", "Province")
                        .WithMany("Cities")
                        .HasForeignKey("ProvinceCode");

                    b.Navigation("Province");
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

            modelBuilder.Entity("Lab04.Models.Province", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
