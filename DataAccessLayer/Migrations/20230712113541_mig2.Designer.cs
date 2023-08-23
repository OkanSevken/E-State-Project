﻿// <auto-generated />
using System;
using DataAccessLayer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230712113541_mig2")]
    partial class mig2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Entities.Advert", b =>
                {
                    b.Property<int>("AdvertId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvertId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("AdvertDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AdvertTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AirCordinator")
                        .HasColumnType("bit");

                    b.Property<int>("Area")
                        .HasColumnType("int");

                    b.Property<int>("BathroomNumbers")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<bool>("Credit")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<bool>("Fireplace")
                        .HasColumnType("bit");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<bool>("Furniture")
                        .HasColumnType("bit");

                    b.Property<string>("Garage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Garden")
                        .HasColumnType("bit");

                    b.Property<int>("NeighbourhoodId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<bool>("Pool")
                        .HasColumnType("bit");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SituationId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("Teras")
                        .HasColumnType("bit");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserAdminId")
                        .HasColumnType("int");

                    b.Property<string>("UserAdminId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("AdvertId");

                    b.HasIndex("NeighbourhoodId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserAdminId1");

                    b.ToTable("Adverts");
                });

            modelBuilder.Entity("EntityLayer.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("EntityLayer.Entities.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("EntityLayer.Entities.GeneralSettings", b =>
                {
                    b.Property<int>("GeneralSettingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GeneralSettingsId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GeneralSettingsId");

                    b.ToTable("GeneralSettings");
                });

            modelBuilder.Entity("EntityLayer.Entities.Images", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageId"), 1L, 1);

                    b.Property<int>("AdvertId")
                        .HasColumnType("int");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ImageId");

                    b.HasIndex("AdvertId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EntityLayer.Entities.Neighbourhood", b =>
                {
                    b.Property<int>("NeighbourhoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NeighbourhoodId"), 1L, 1);

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("NeighbourhoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("NeighbourhoodId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Neighbourhoods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Situation", b =>
                {
                    b.Property<int>("SituationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SituationId"), 1L, 1);

                    b.Property<string>("SituationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("SituationId");

                    b.ToTable("Situations");
                });

            modelBuilder.Entity("EntityLayer.Entities.Type", b =>
                {
                    b.Property<int>("TypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeId"), 1L, 1);

                    b.Property<int>("SituationId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeId");

                    b.HasIndex("SituationId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("EntityLayer.Entities.UserAdmin", b =>
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

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EntityLayer.Entities.Advert", b =>
                {
                    b.HasOne("EntityLayer.Entities.Neighbourhood", "Neighbourhood")
                        .WithMany()
                        .HasForeignKey("NeighbourhoodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.Type", "Type")
                        .WithMany("Adverts")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Entities.UserAdmin", "UserAdmin")
                        .WithMany("Adverts")
                        .HasForeignKey("UserAdminId1");

                    b.Navigation("Neighbourhood");

                    b.Navigation("Type");

                    b.Navigation("UserAdmin");
                });

            modelBuilder.Entity("EntityLayer.Entities.District", b =>
                {
                    b.HasOne("EntityLayer.Entities.City", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("EntityLayer.Entities.Images", b =>
                {
                    b.HasOne("EntityLayer.Entities.Advert", "Advert")
                        .WithMany("Images")
                        .HasForeignKey("AdvertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("EntityLayer.Entities.Neighbourhood", b =>
                {
                    b.HasOne("EntityLayer.Entities.District", "District")
                        .WithMany("Neighbourhoods")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("District");
                });

            modelBuilder.Entity("EntityLayer.Entities.Type", b =>
                {
                    b.HasOne("EntityLayer.Entities.Situation", "Situation")
                        .WithMany("Types")
                        .HasForeignKey("SituationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Situation");
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
                    b.HasOne("EntityLayer.Entities.UserAdmin", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.UserAdmin", null)
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

                    b.HasOne("EntityLayer.Entities.UserAdmin", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EntityLayer.Entities.UserAdmin", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Entities.Advert", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("EntityLayer.Entities.City", b =>
                {
                    b.Navigation("Districts");
                });

            modelBuilder.Entity("EntityLayer.Entities.District", b =>
                {
                    b.Navigation("Neighbourhoods");
                });

            modelBuilder.Entity("EntityLayer.Entities.Situation", b =>
                {
                    b.Navigation("Types");
                });

            modelBuilder.Entity("EntityLayer.Entities.Type", b =>
                {
                    b.Navigation("Adverts");
                });

            modelBuilder.Entity("EntityLayer.Entities.UserAdmin", b =>
                {
                    b.Navigation("Adverts");
                });
#pragma warning restore 612, 618
        }
    }
}
