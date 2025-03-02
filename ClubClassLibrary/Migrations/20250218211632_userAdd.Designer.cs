﻿// <auto-generated />
using System;
using ClubClassLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClubClassLibrary.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250218211632_userAdd")]
    partial class userAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClubClassLibrary.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            BirthDate = new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2025, 2, 18, 23, 16, 31, 824, DateTimeKind.Local).AddTicks(2383),
                            Name = "John Doe",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St",
                            BirthDate = new DateTime(1985, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JoinDate = new DateTime(2025, 2, 18, 23, 16, 31, 824, DateTimeKind.Local).AddTicks(2400),
                            Name = "Jane Smith",
                            PhoneNumber = "9876543210"
                        });
                });

            modelBuilder.Entity("ClubClassLibrary.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("MembershipTypeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("ClubClassLibrary.Models.MembershipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MembershipTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasePrice = 50m,
                            Description = "Basic membership",
                            Name = "Standard"
                        },
                        new
                        {
                            Id = 2,
                            BasePrice = 100m,
                            Description = "Premium membership with extra features",
                            Name = "Premium"
                        });
                });

            modelBuilder.Entity("ClubClassLibrary.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<int>("MembershipId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("MembershipId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("ClubClassLibrary.SystemUsers.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St",
                            DateCreated = new DateTime(2025, 2, 18, 23, 16, 31, 948, DateTimeKind.Local).AddTicks(2536),
                            Email = "admin@example.com",
                            Name = "Admin User",
                            Password = "$2a$11$mURUNCkbVkejWceHL.s3Ce8.BkVD0S67s2gzJAjKTGjgj7X8lLa.u",
                            Phone = "123-456-7890",
                            Role = "Admin",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Oak Ave",
                            DateCreated = new DateTime(2025, 2, 18, 23, 16, 32, 55, DateTimeKind.Local).AddTicks(6908),
                            Email = "user1@example.com",
                            Name = "Regular User 1",
                            Password = "$2a$11$Esj.YqKC3lrGrTrFlhzjqe84WQVgSyYhjcVm3LI2KHKmIGa/3ySkG",
                            Phone = "987-654-3210",
                            Role = "User",
                            Status = "Active"
                        },
                        new
                        {
                            Id = 3,
                            Address = "789 Pine Ln",
                            DateCreated = new DateTime(2025, 2, 11, 23, 16, 32, 162, DateTimeKind.Local).AddTicks(2288),
                            Email = "user2@example.com",
                            Name = "Regular User 2",
                            Password = "$2a$11$xVbtgyD/hpOdLIsyHPYGu.UAFrZrG2TAqRoIJ35XpLdAi7J5nD5bC",
                            Phone = "555-123-4567",
                            Role = "User",
                            Status = "Pending"
                        });
                });

            modelBuilder.Entity("ClubClassLibrary.Models.Membership", b =>
                {
                    b.HasOne("ClubClassLibrary.Models.Member", "Member")
                        .WithMany("Memberships")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClubClassLibrary.Models.MembershipType", "MembershipType")
                        .WithMany("Memberships")
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("MembershipType");
                });

            modelBuilder.Entity("ClubClassLibrary.Models.Payment", b =>
                {
                    b.HasOne("ClubClassLibrary.Models.Member", "Member")
                        .WithMany("Payments")
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("ClubClassLibrary.Models.Membership", "Membership")
                        .WithMany("Payments")
                        .HasForeignKey("MembershipId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("Membership");
                });

            modelBuilder.Entity("ClubClassLibrary.Models.Member", b =>
                {
                    b.Navigation("Memberships");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("ClubClassLibrary.Models.Membership", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("ClubClassLibrary.Models.MembershipType", b =>
                {
                    b.Navigation("Memberships");
                });
#pragma warning restore 612, 618
        }
    }
}
