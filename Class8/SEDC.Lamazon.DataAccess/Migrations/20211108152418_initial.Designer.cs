﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEDC.Lamazon.DataAccess;

namespace SEDC.Lamazon.DataAccess.Migrations
{
    [DbContext(typeof(LamazonDbContext))]
    [Migration("20211108152418_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasData(
                        new { Id = "7575b868-b0d2-4f38-a603-b943b44d931a", ConcurrencyStamp = "0d8b109d-e634-45b5-805d-8416bd59d919", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "adec2e51-0baa-4e92-87fc-235cb733ce0b", ConcurrencyStamp = "9fa2c9c2-c0c6-4d79-ad31-ab522d91c33f", Name = "user", NormalizedName = "USER" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.HasData(
                        new { UserId = "4b436dac-8b63-4a32-9295-8caff2c494a5", RoleId = "7575b868-b0d2-4f38-a603-b943b44d931a" },
                        new { UserId = "4f0046fc-f901-4fab-81e8-774ce4daff03", RoleId = "adec2e51-0baa-4e92-87fc-235cb733ce0b" }
                    );
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

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfOrder");

                    b.Property<bool>("IsPaid");

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new { Id = 1, DateOfOrder = new DateTime(2021, 11, 8, 15, 24, 17, 893, DateTimeKind.Utc), IsPaid = false, Status = 0, UserId = "4f0046fc-f901-4fab-81e8-774ce4daff03" },
                        new { Id = 2, DateOfOrder = new DateTime(2021, 11, 8, 15, 24, 17, 893, DateTimeKind.Utc), IsPaid = false, Status = 1, UserId = "4f0046fc-f901-4fab-81e8-774ce4daff03" }
                    );
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new { Id = 1, Category = 2, Description = "Very good phone. Bad batery", Name = "Samsung A40", Price = 200.0 },
                        new { Id = 2, Category = 2, Description = "Large SSD of high quality", Name = "SSD 1TB", Price = 400.0 },
                        new { Id = 3, Category = 3, Description = "C# Book for everyone", Name = "C# in depth", Price = 40.0 },
                        new { Id = 4, Category = 3, Description = "Book for clean code", Name = "Clean Code", Price = 60.0 },
                        new { Id = 5, Category = 1, Description = "Magical Elixir of Power", Name = "Rakija", Price = 20.0 },
                        new { Id = 6, Category = 1, Description = "When you have too much Rakija", Name = "Sparkling Water", Price = 2.0 },
                        new { Id = 7, Category = 0, Description = "All in one pack of appetizers", Name = "Meze", Price = 15.0 },
                        new { Id = 8, Category = 0, Description = "Stew for good morning", Name = "Stew in a can", Price = 8.0 },
                        new { Id = 9, Category = 4, Description = "Set of 6 glasses", Name = "Glasses set", Price = 10.0 },
                        new { Id = 10, Category = 4, Description = "Set of 20 plastic knives and forks", Name = "Plastic knives and forks", Price = 4.0 },
                        new { Id = 11, Category = 4, Description = "A bag of ice", Name = "Ice", Price = 3.0 },
                        new { Id = 12, Category = 4, Description = "Plates for the whole family", Name = "Plastic plates", Price = 5.0 }
                    );
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("OrderId");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ProductId", "OrderId");

                    b.HasAlternateKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("ProductOrders");

                    b.HasData(
                        new { ProductId = 1, OrderId = 1, Id = 1 },
                        new { ProductId = 3, OrderId = 1, Id = 2 },
                        new { ProductId = 5, OrderId = 1, Id = 3 },
                        new { ProductId = 1, OrderId = 2, Id = 4 },
                        new { ProductId = 2, OrderId = 2, Id = 5 }
                    );
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

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

                    b.HasData(
                        new { Id = "4b436dac-8b63-4a32-9295-8caff2c494a5", AccessFailedCount = 0, ConcurrencyStamp = "3067b186-9cd4-4f67-b0a1-c784682660b2", Email = "lamazon@supply.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "lamazon@supply.com", NormalizedUserName = "ADMIN", PasswordHash = "AQAAAAEAACcQAAAAEBN4hSofnzGxzcFFxBkoDN9G27QvBl73qkLGck9NMsKoYtq8jtUtRkqkNECBtdvNXA==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = "4f0046fc-f901-4fab-81e8-774ce4daff03", AccessFailedCount = 0, ConcurrencyStamp = "45d274a0-ae41-455d-a83c-e4ed00f22a72", Email = "pane@mail.com", EmailConfirmed = true, FullName = "Pane Manaskov", LockoutEnabled = false, NormalizedEmail = "PANE@MAIL.COM", NormalizedUserName = "PANE.MANASKOV", PasswordHash = "AQAAAAEAACcQAAAAEAMndkeMnCW6ymYRlkp2ZECvjQkVcRJVVoPb3/cWcFD8HdRCXmOq7qKWpxUTt66MFA==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "pane.manaskov" }
                    );
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
                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
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

                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.Order", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SEDC.Lamazon.Domain.Models.ProductOrder", b =>
                {
                    b.HasOne("SEDC.Lamazon.Domain.Models.Order", "Order")
                        .WithMany("ProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEDC.Lamazon.Domain.Models.Product", "Product")
                        .WithMany("ProductOrders")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
