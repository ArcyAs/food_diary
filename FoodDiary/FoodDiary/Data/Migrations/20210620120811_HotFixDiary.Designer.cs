﻿// <auto-generated />
using System;
using FoodDiary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodDiary.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210620120811_HotFixDiary")]
    partial class HotFixDiary
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("FoodDiary.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ActivityLevel")
                        .HasColumnType("REAL");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

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

            modelBuilder.Entity("FoodDiary.Repositories.Entities.DiaryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("DiaryId")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("TEXT");

                    b.Property<int>("Kcal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Weight")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("DiaryEntities");
                });

            modelBuilder.Entity("FoodDiary.Repositories.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("Carb")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Fat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kcal")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Protein")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("ProductEntities");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6c23e458-0053-494a-901b-9c315b9e67de"),
                            Carb = 52,
                            Fat = 10,
                            Kcal = 345,
                            ProductName = "Muesli (Almond)",
                            Protein = 12
                        },
                        new
                        {
                            Id = new Guid("4edf9a5f-aa25-4d6a-a349-7927602d691b"),
                            Carb = 60,
                            Fat = 10,
                            Kcal = 383,
                            ProductName = "Wholegrain Rolled Oats",
                            Protein = 13
                        },
                        new
                        {
                            Id = new Guid("51e4cab8-194a-43aa-8ba0-6f5ade840569"),
                            Carb = 0,
                            Fat = 9,
                            Kcal = 144,
                            ProductName = "Firm Tofu",
                            Protein = 16
                        },
                        new
                        {
                            Id = new Guid("9952553e-889e-4bc4-b0b6-a689b8dca4a5"),
                            Carb = 5,
                            Fat = 11,
                            Kcal = 149,
                            ProductName = "Hummus",
                            Protein = 8
                        },
                        new
                        {
                            Id = new Guid("b6cf197f-e6f3-47ad-8201-7208e0fb6166"),
                            Carb = 16,
                            Fat = 9,
                            Kcal = 166,
                            ProductName = "Hummus (Lite)",
                            Protein = 5
                        },
                        new
                        {
                            Id = new Guid("37f7631a-d3e1-4a0b-b25f-5c94a17d5470"),
                            Carb = 17,
                            Fat = 19,
                            Kcal = 262,
                            ProductName = "Hummus",
                            Protein = 6
                        },
                        new
                        {
                            Id = new Guid("a4b5f688-fd68-4f06-9dcf-1a0ea3633630"),
                            Carb = 12,
                            Fat = 50,
                            Kcal = 610,
                            ProductName = "Peanut Butter",
                            Protein = 28
                        },
                        new
                        {
                            Id = new Guid("fb6dc119-0a9e-47a4-b38c-48d321cf88ba"),
                            Carb = 18,
                            Fat = 51,
                            Kcal = 644,
                            ProductName = "Peanut Butter",
                            Protein = 28
                        },
                        new
                        {
                            Id = new Guid("e577c8cf-b1ab-4955-9abe-bbd728b8045f"),
                            Carb = 12,
                            Fat = 57,
                            Kcal = 666,
                            ProductName = "Tahini",
                            Protein = 26
                        },
                        new
                        {
                            Id = new Guid("7d571984-8e31-4b59-bb9a-32b701d9063a"),
                            Carb = 15,
                            Fat = 1,
                            Kcal = 98,
                            ProductName = "Butter Beans",
                            Protein = 7
                        },
                        new
                        {
                            Id = new Guid("af3363c6-fd4b-42da-b8df-f7b2aafd4ef2"),
                            Carb = 16,
                            Fat = 0,
                            Kcal = 89,
                            ProductName = "Kidney Beans",
                            Protein = 5
                        },
                        new
                        {
                            Id = new Guid("12e31dc1-ffb4-4a06-aab9-402ba89ddb5d"),
                            Carb = 15,
                            Fat = 0,
                            Kcal = 96,
                            ProductName = "Chickpeas",
                            Protein = 8
                        },
                        new
                        {
                            Id = new Guid("01fd3fc8-66e1-4d4d-b3c6-b3375c69116a"),
                            Carb = 11,
                            Fat = 1,
                            Kcal = 70,
                            ProductName = "Lentils",
                            Protein = 4
                        },
                        new
                        {
                            Id = new Guid("354d83a8-0eab-4038-88c0-c2cb80063b76"),
                            Carb = 14,
                            Fat = 1,
                            Kcal = 93,
                            ProductName = "Cannellini Beans",
                            Protein = 7
                        },
                        new
                        {
                            Id = new Guid("9ceaaadb-bbbc-40a3-b8bc-c54dfa5d1e01"),
                            Carb = 14,
                            Fat = 1,
                            Kcal = 93,
                            ProductName = "Beans",
                            Protein = 7
                        },
                        new
                        {
                            Id = new Guid("371b1e6f-1dac-46af-9757-1ddc4cc6d811"),
                            Carb = 15,
                            Fat = 1,
                            Kcal = 68,
                            ProductName = "Kiwifruit",
                            Protein = 1
                        },
                        new
                        {
                            Id = new Guid("d433524e-fa48-4159-8a56-789ecbc70633"),
                            Carb = 14,
                            Fat = 0,
                            Kcal = 58,
                            ProductName = "Apple (Granny Smith)",
                            Protein = 0
                        },
                        new
                        {
                            Id = new Guid("1a62fe57-e5d3-4c34-a2a7-a5b22b8947b5"),
                            Carb = 14,
                            Fat = 0,
                            Kcal = 58,
                            ProductName = "Apple (Pink Lady)",
                            Protein = 0
                        });
                });

            modelBuilder.Entity("FoodDiary.Repositories.Entities.UserDetailsEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("TEXT");

                    b.Property<double>("Bmi")
                        .HasColumnType("REAL");

                    b.Property<double>("Bmr")
                        .HasColumnType("REAL");

                    b.Property<Guid>("DiaryId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Target")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("UserDetailsEntities");
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
                    b.HasOne("FoodDiary.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FoodDiary.Models.AppUser", null)
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

                    b.HasOne("FoodDiary.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FoodDiary.Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}