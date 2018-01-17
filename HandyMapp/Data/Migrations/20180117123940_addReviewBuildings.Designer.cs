﻿// <auto-generated />
using HandyMapp.Data;
using HandyMapp.Models.Navigation;
using HandyMapp.Models.Review;
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
    [Migration("20180117123940_addReviewBuildings")]
    partial class addReviewBuildings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HandyMapp.Models.AddressModels.Address", b =>
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

            modelBuilder.Entity("HandyMapp.Models.AddressModels.City", b =>
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

            modelBuilder.Entity("HandyMapp.Models.AddressModels.Country", b =>
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

            modelBuilder.Entity("HandyMapp.Models.AddressModels.PostCode", b =>
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

            modelBuilder.Entity("HandyMapp.Models.AddressModels.Province", b =>
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

            modelBuilder.Entity("HandyMapp.Models.AddressModels.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LongName")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Streets");
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

            modelBuilder.Entity("HandyMapp.Models.Navigation.Obstacle", b =>
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

                    b.ToTable("Obstacle");
                });

            modelBuilder.Entity("HandyMapp.Models.Navigation.Vector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double?>("Latitude");

                    b.Property<double?>("Longitude");

                    b.Property<double>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Vectors");
                });

            modelBuilder.Entity("HandyMapp.Models.Navigation.VectorPath", b =>
                {
                    b.Property<int>("VectorId1");

                    b.Property<int>("VectorId2");

                    b.Property<double?>("Distance");

                    b.HasKey("VectorId1", "VectorId2");

                    b.HasIndex("VectorId2");

                    b.ToTable("VectorPaths");
                });

            modelBuilder.Entity("HandyMapp.Models.Review.ReviewBuilding", b =>
                {
                    b.Property<string>("PlaceId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessibleToilets");

                    b.Property<string>("Description");

                    b.Property<int>("Elevators");

                    b.Property<int>("HallwaysWide");

                    b.Property<int>("LooseTilesOrFloormats");

                    b.Property<int>("Ramps");

                    b.Property<int>("Rating");

                    b.Property<int>("Threshold");

                    b.HasKey("PlaceId");

                    b.ToTable("ReviewBuildings");
                });

            modelBuilder.Entity("HandyMapp.Models.street_eval_model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("aid");

                    b.Property<string>("description");

                    b.Property<string>("lat");

                    b.Property<string>("lng");

                    b.Property<string>("obst_type");

                    b.Property<string>("rating");

                    b.HasKey("Id");

                    b.ToTable("StreetEvalModels");
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

            modelBuilder.Entity("HandyMapp.Models.AddressModels.Address", b =>
                {
                    b.HasOne("HandyMapp.Models.AddressModels.City", "City")
                        .WithMany("Address")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK_Address_City");

                    b.HasOne("HandyMapp.Models.AddressModels.Country", "Country")
                        .WithMany("Address")
                        .HasForeignKey("CountryId")
                        .HasConstraintName("FK_Address_Country");

                    b.HasOne("HandyMapp.Models.AddressModels.PostCode", "PostCode")
                        .WithMany("Address")
                        .HasForeignKey("PostCodeId")
                        .HasConstraintName("FK_Address_PostCode");

                    b.HasOne("HandyMapp.Models.AddressModels.Province", "Province")
                        .WithMany("Address")
                        .HasForeignKey("ProvinceId")
                        .HasConstraintName("FK_Address_Province");

                    b.HasOne("HandyMapp.Models.AddressModels.Street", "Street")
                        .WithMany("Address")
                        .HasForeignKey("StreetId")
                        .HasConstraintName("FK_Address_Street");
                });

            modelBuilder.Entity("HandyMapp.Models.Navigation.Obstacle", b =>
                {
                    b.HasOne("HandyMapp.Models.Navigation.Vector", "Vector")
                        .WithMany("Obstacle")
                        .HasForeignKey("VectorId")
                        .HasConstraintName("FK_Obstacle_Vector");
                });

            modelBuilder.Entity("HandyMapp.Models.Navigation.VectorPath", b =>
                {
                    b.HasOne("HandyMapp.Models.Navigation.Vector", "VectorId1Navigation")
                        .WithMany("VectorPathVectorId1Navigation")
                        .HasForeignKey("VectorId1")
                        .HasConstraintName("FK_VectorPath_Vector");

                    b.HasOne("HandyMapp.Models.Navigation.Vector", "VectorId2Navigation")
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
