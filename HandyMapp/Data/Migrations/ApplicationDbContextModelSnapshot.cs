﻿// <auto-generated />
using Handy_Mapp.Models.Navigation;
using HandyMapp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HandyMapp.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CaneRating");

                    b.Property<int>("CityId");

                    b.Property<int>("CountryId");

                    b.Property<string>("PlaceId")
                        .IsRequired();

                    b.Property<int?>("PostCodeId");

                    b.Property<int>("ProvinceId");

                    b.Property<int>("ScooterRating");

                    b.Property<int>("StreetId");

                    b.Property<string>("StreetNumber")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<int>("WalkerRating");

                    b.Property<int>("WeelchairRating");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("PostCodeId");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("StreetId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ShortName")
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ShortName")
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.PostCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PostCode1")
                        .IsRequired()
                        .HasColumnName("PostCode")
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.ToTable("PostCodes");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongName")
                        .IsRequired()
                        .HasColumnType("nchar(10)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Navigation.Obstacle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ObstacleType");

                    b.Property<int>("Rating");

                    b.Property<int?>("VectorId");

                    b.Property<double?>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("VectorId");

                    b.ToTable("Obstacles");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Navigation.Vector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("Latitude");

                    b.Property<double?>("Longitude");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Vectors");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Navigation.VectorPath", b =>
                {
                    b.Property<int>("VectorId1");

                    b.Property<int>("VectorId2");

                    b.Property<double?>("Distance");

                    b.HasKey("VectorId1", "VectorId2");

                    b.HasIndex("VectorId2");

                    b.ToTable("VectorPaths");
                });

            modelBuilder.Entity("HandyMapp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("HandyMapp.Models.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Example");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Addresmoddels.Address", b =>
                {
                    b.HasOne("Handy_Mapp.Models.Addresmoddels.City", "City")
                        .WithMany("Address")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Address_City");

                    b.HasOne("Handy_Mapp.Models.Addresmoddels.Country", "Country")
                        .WithMany("Address")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Address_Country");

                    b.HasOne("Handy_Mapp.Models.Addresmoddels.PostCode", "PostCode")
                        .WithMany("Address")
                        .HasForeignKey("PostCodeId")
                        .HasConstraintName("FK_Address_PostCode");

                    b.HasOne("Handy_Mapp.Models.Addresmoddels.Province", "Province")
                        .WithMany("Address")
                        .HasForeignKey("ProvinceId")
                        .HasConstraintName("FK_Address_Province");

                    b.HasOne("Handy_Mapp.Models.Addresmoddels.Street", "Street")
                        .WithMany("Address")
                        .HasForeignKey("StreetId")
                        .HasConstraintName("FK_Address_Street");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Navigation.Obstacle", b =>
                {
                    b.HasOne("Handy_Mapp.Models.Navigation.Vector", "Vector")
                        .WithMany("Obstacle")
                        .HasForeignKey("VectorId")
                        .HasConstraintName("FK_Obstacle_Vector");
                });

            modelBuilder.Entity("Handy_Mapp.Models.Navigation.VectorPath", b =>
                {
                    b.HasOne("Handy_Mapp.Models.Navigation.Vector", "VectorId1Navigation")
                        .WithMany("VectorPathVectorId1Navigation")
                        .HasForeignKey("VectorId1")
                        .HasConstraintName("FK_VectorPath_Vector");

                    b.HasOne("Handy_Mapp.Models.Navigation.Vector", "VectorId2Navigation")
                        .WithMany("VectorPathVectorId2Navigation")
                        .HasForeignKey("VectorId2")
                        .HasConstraintName("FK_VectorPath_Vector1");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("HandyMapp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("HandyMapp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HandyMapp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("HandyMapp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
