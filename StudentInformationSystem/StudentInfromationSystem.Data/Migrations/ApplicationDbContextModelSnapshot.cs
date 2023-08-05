﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentInformationSystem.Data;

#nullable disable

namespace StudentInformationSystem.Data.Migrations
{
    [DbContext(typeof(StudentInformationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.HasData(
                        new
                        {
                            Id = "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "867cac39-9977-45ea-86a6-0cd04535ec30",
                            Email = "teacher@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "teacher@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEDA63n7bXBCA8k0uO4iJN3mGS7nGLE2WwOpbfbHu0c/emPTnoCxuH8EisJPdkDD9hA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6fb5e7a4-da27-4a7d-9070-fb68c9d7b821",
                            TwoFactorEnabled = false,
                            UserName = "teacher@abv.bg"
                        },
                        new
                        {
                            Id = "47af10f2-ef33-4637-a18f-40c27c56acb7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1d8f2c16-42ff-477e-ad0c-a7f887d70358",
                            Email = "student@university.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "student@university.com",
                            NormalizedUserName = "student@university.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEA4xo3mESScgWxbuX/xYtvZoC0eSm/0eB45xCftZdw8J8Q88ViHn+gkt+itni1uZyg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "f3dc7149-28b9-494e-8838-c92834988536",
                            TwoFactorEnabled = false,
                            UserName = "student@university.com"
                        });
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

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<TimeSpan>("End")
                        .HasColumnType("time");

                    b.Property<int>("LectureRoom")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Start")
                        .HasColumnType("time");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SpecialtyId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Credits = 6,
                            DayOfWeek = 1,
                            Description = "Mathematics is the study of numbers, shapes and patterns. The word comes from the Greek word (mathema), meaning science, knowledge, or learning, and is sometimes shortened to maths (in England, Australia, Ireland, and New Zealand) or math (in the United States and Canada).",
                            End = new TimeSpan(0, 11, 30, 0, 0),
                            LectureRoom = 101,
                            Name = "Mathematics",
                            SpecialtyId = 1,
                            Start = new TimeSpan(0, 10, 0, 0, 0),
                            TeacherId = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                        },
                        new
                        {
                            Id = 2,
                            Credits = 10,
                            DayOfWeek = 2,
                            Description = "An algorithm is a set of instructions designed to perform a specific task. This can be a simple process, such as multiplying two numbers, or a complex operation, such as playing a compressed video file. Search engines use proprietary algorithms to display the most relevant results from their search index for specific queries.",
                            End = new TimeSpan(0, 13, 30, 0, 0),
                            LectureRoom = 102,
                            Name = "Algorithms and Data Structures",
                            SpecialtyId = 1,
                            Start = new TimeSpan(0, 12, 0, 0, 0),
                            TeacherId = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                        },
                        new
                        {
                            Id = 3,
                            Credits = 8,
                            DayOfWeek = 3,
                            Description = "Object-oriented programming (OOP) is a programming paradigm based on the concept of \"objects\", which can contain data and code: data in the form of fields (often known as attributes or properties), and code, in the form of procedures (often known as methods).",
                            End = new TimeSpan(0, 15, 30, 0, 0),
                            LectureRoom = 103,
                            Name = "Object-Oriented Programming",
                            SpecialtyId = 1,
                            Start = new TimeSpan(0, 14, 0, 0, 0),
                            TeacherId = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                        },
                        new
                        {
                            Id = 4,
                            Credits = 8,
                            DayOfWeek = 4,
                            Description = "Software engineering is the systematic application of engineering approaches to the development of software. Software engineering is a computing discipline.",
                            End = new TimeSpan(0, 17, 30, 0, 0),
                            LectureRoom = 104,
                            Name = "Software Engineering",
                            SpecialtyId = 2,
                            Start = new TimeSpan(0, 16, 0, 0, 0),
                            TeacherId = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                        },
                        new
                        {
                            Id = 5,
                            Credits = 8,
                            DayOfWeek = 5,
                            Description = "Business administration is the process of managing a business or non-profit organization so that it remains stable and continues to grow. This consists of a number of areas, ranging from operations to management.",
                            End = new TimeSpan(0, 11, 30, 0, 0),
                            LectureRoom = 201,
                            Name = "Business Administration",
                            SpecialtyId = 3,
                            Start = new TimeSpan(0, 10, 0, 0, 0),
                            TeacherId = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                        },
                        new
                        {
                            Id = 6,
                            Credits = 8,
                            DayOfWeek = 5,
                            Description = "Law is a system of rules created and enforced through social or governmental institutions to regulate behavior, with its precise definition a matter of longstanding debate. It has been variously described as a science and the art of justice.",
                            End = new TimeSpan(0, 13, 30, 0, 0),
                            LectureRoom = 202,
                            Name = "Law",
                            SpecialtyId = 4,
                            Start = new TimeSpan(0, 12, 0, 0, 0),
                            TeacherId = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                        });
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UniversityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UniversityId");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Faculty of Mathematics and Informatics",
                            UniversityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Faculty of Economics and Business Administration",
                            UniversityId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Faculty of Law",
                            UniversityId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Faculty of German Engineering",
                            UniversityId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Faculty of Philosophy",
                            UniversityId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Faculty of Computer Systems and Control",
                            UniversityId = 1
                        });
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FacultyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Specialties");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FacultyId = 1,
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 2,
                            FacultyId = 1,
                            Name = "Software Engineering"
                        },
                        new
                        {
                            Id = 3,
                            FacultyId = 2,
                            Name = "Business Administration"
                        },
                        new
                        {
                            Id = 4,
                            FacultyId = 3,
                            Name = "Law"
                        });
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FacultyNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsForeign")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("SpecialtyId");

                    b.HasIndex("UserId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                            EGN = "1234567890",
                            Email = "student@university.com",
                            FacultyNumber = "123456789",
                            FirstName = "Ivan",
                            IsActive = true,
                            IsForeign = false,
                            LastName = "Ivanov",
                            PhoneNumber = "0888123456",
                            SpecialtyId = 1,
                            UserId = "47af10f2-ef33-4637-a18f-40c27c56acb7"
                        });
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.StudentCourses", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                            CourseId = 1,
                            Grade = 0.0
                        },
                        new
                        {
                            StudentId = new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                            CourseId = 2,
                            Grade = 0.0
                        },
                        new
                        {
                            StudentId = new Guid("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                            CourseId = 3,
                            Grade = 0.0
                        });
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EGN")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                            EGN = "1234567890",
                            Email = "teacher@abv.bg",
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            PhoneNumber = "0888123456",
                            UserId = "20661c81-53ef-45dd-ab1c-0c5aee24c90d"
                        });
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "8 Kliment Ohridski Blvd., 1000 Sofia, Bulgaria",
                            Name = "Technical University of Sofia",
                            PostCode = "1257"
                        },
                        new
                        {
                            Id = 2,
                            Address = "15 Tsar Osvoboditel Blvd., 1504 Sofia, Bulgaria",
                            Name = "Sofia University St. Kliment Ohridski",
                            PostCode = "1257"
                        },
                        new
                        {
                            Id = 3,
                            Address = "8 Kliment Ohridski Blvd., 1000 Sofia, Bulgaria",
                            Name = "University of National and World Economy",
                            PostCode = "1257"
                        });
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

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Course", b =>
                {
                    b.HasOne("StudentInformationSystem.Data.Models.Specialty", "Specialty")
                        .WithMany("Courses")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentInformationSystem.Data.Models.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Specialty");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Faculty", b =>
                {
                    b.HasOne("StudentInformationSystem.Data.Models.University", "University")
                        .WithMany("Faculties")
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Specialty", b =>
                {
                    b.HasOne("StudentInformationSystem.Data.Models.Faculty", "Faculty")
                        .WithMany("Specialties")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Student", b =>
                {
                    b.HasOne("StudentInformationSystem.Data.Models.Specialty", "Specialty")
                        .WithMany("Students")
                        .HasForeignKey("SpecialtyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialty");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.StudentCourses", b =>
                {
                    b.HasOne("StudentInformationSystem.Data.Models.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentInformationSystem.Data.Models.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Teacher", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Course", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Faculty", b =>
                {
                    b.Navigation("Specialties");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Specialty", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.Teacher", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("StudentInformationSystem.Data.Models.University", b =>
                {
                    b.Navigation("Faculties");
                });
#pragma warning restore 612, 618
        }
    }
}
