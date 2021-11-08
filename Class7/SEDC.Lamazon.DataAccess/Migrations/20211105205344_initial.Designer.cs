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
    [Migration("20211105205344_initial")]
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
                        new { Id = "8d01e4a2-b562-4afa-9ff6-a09854e420d8", ConcurrencyStamp = "8980f060-0e5d-4104-a2f2-0990b9801551", Name = "admin", NormalizedName = "ADMIN" },
                        new { Id = "2266ef0d-1108-4749-ad39-89a08df6d5c7", ConcurrencyStamp = "3d2e24db-3e15-4a7d-873e-19858d13dce4", Name = "user", NormalizedName = "USER" }
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
                        new { UserId = "839cdb71-281d-44be-a6f4-671898df9183", RoleId = "8d01e4a2-b562-4afa-9ff6-a09854e420d8" },
                        new { UserId = "24c818d2-b919-440e-8984-5ebb314a7340", RoleId = "2266ef0d-1108-4749-ad39-89a08df6d5c7" }
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
                        new { Id = 1, DateOfOrder = new DateTime(2021, 11, 5, 20, 53, 44, 169, DateTimeKind.Utc), IsPaid = false, Status = 0, UserId = "24c818d2-b919-440e-8984-5ebb314a7340" },
                        new { Id = 2, DateOfOrder = new DateTime(2021, 11, 5, 20, 53, 44, 169, DateTimeKind.Utc), IsPaid = false, Status = 1, UserId = "24c818d2-b919-440e-8984-5ebb314a7340" }
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
                        new { Id = "839cdb71-281d-44be-a6f4-671898df9183", AccessFailedCount = 0, ConcurrencyStamp = "da0dcbdd-2a02-4bc4-90f1-236d3cc329e6", Email = "lamazon@supply.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "lamazon@supply.com", NormalizedUserName = "ADMIN", PasswordHash = "AQAAAAEAACcQAAAAENRsOOS/UXbSyFICqTqP530Suo+U+Prtze31uKMjn8krmhoMqn6WkACRaAL2Fno3Pg==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "admin" },
                        new { Id = "24c818d2-b919-440e-8984-5ebb314a7340", AccessFailedCount = 0, ConcurrencyStamp = "a6549416-13ac-4b29-a311-dfd1c00a95a4", Email = "pane@mail.com", EmailConfirmed = true, FullName = "Pane Manaskov", LockoutEnabled = false, NormalizedEmail = "PANE@MAIL.COM", NormalizedUserName = "PANE.MANASKOV", PasswordHash = "AQAAAAEAACcQAAAAECnR+2zW+hSzyFXFr1E0p59wrUIDrrpeYKbUSoEQj42P3JecDelNqsR77YrHYGr8qA==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "pane.manaskov" }
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