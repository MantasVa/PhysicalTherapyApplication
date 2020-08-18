﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhysicalTherapyProject.Persistance.Data;

namespace PhysicalTherapyProject.Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200818065935_addedNavigationalPropertyForImages")]
    partial class addedNavigationalPropertyForImages
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.ApplicationRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "d7d06b81-365c-4c58-a5b2-1165e776fdc4",
                            Name = "Administrator"
                        });
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int?>("ImageId")
                        .HasColumnType("int");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<int>("OccupationId")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("OccupationId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Content")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PostId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Occupation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1138),
                            Name = "Studentas",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1152)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1466),
                            Name = "Dėstytojas",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1477)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1488),
                            Name = "Kineziterapeutas",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(1492)
                        });
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PostTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("PostUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isForAuthenticatedUser")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PostTypeId");

                    b.HasIndex("PostUserId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 354, DateTimeKind.Local).AddTicks(8710),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 1,
                            Title = "What is Lorem Ipsum?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 354, DateTimeKind.Local).AddTicks(8735),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 2,
                            Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(462),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 1,
                            Title = "1914 translation by H. Rackham",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(478),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 3,
                            Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(527),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 1,
                            Title = "The standard Lorem Ipsum passage, used since the 1500s",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(531),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 4,
                            Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(536),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 1,
                            Title = "Where does it come from?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(539),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 5,
                            Body = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(545),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 1,
                            Title = "Where can I get some?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(548),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 6,
                            Body = "Prezidentė: INESA RIMDEIKIENĖ 861112265 inesa.rimdeikiene@kaunoklinikos.lt Pareigos: draugijos valdybos ir narių atstovavimas, bendravimas su valstybinėmis institucijomis",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(552),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 4,
                            Title = "Where can I get some?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(555),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 7,
                            Body = "RAIMUNDAS VENSKAITIS 862237888 raimundas.venskaitis@gmail.com Pareigos:  draugijos internetinio puslapio ir Facebook paskyros valdymas ir priežiūra",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(560),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 4,
                            Title = "Where can I get some?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(563),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 8,
                            Body = "DOVILĖ VALATKIENĖ –Klaipėdos <b>kr.pirmininkė<b> 861149101 dvalatkiene@yahoo.com klaipedosktd@gmail.com Pareigos: Klaipėdos krašto kineziterapeutų atstovavimas",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(567),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 4,
                            Title = "Where can I get some?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(571),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 9,
                            Body = "BRIGITA ZACHOVAJEVIENĖ – Kauno kr. pirmininkė 8 698 75901 brigitaz@medi.lt Pareigos: sekretorė",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(575),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 4,
                            Title = "Where can I get some?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(578),
                            isForAuthenticatedUser = false
                        },
                        new
                        {
                            Id = 10,
                            Body = "IEVA EGLĖ JAMONTAITĖ  Vilniaus kr.pirmininkė 8 682 45413 ieva.jamontaite@gmail.com Pareigos: LKTD narių narystės tvarkos priežiūra",
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(582),
                            Date = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PostTypeId = 4,
                            Title = "Where can I get some?",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 355, DateTimeKind.Local).AddTicks(586),
                            isForAuthenticatedUser = false
                        });
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.PostType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PostTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 351, DateTimeKind.Local).AddTicks(1279),
                            Name = "Article",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(6977)
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7884),
                            Name = "Event",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7905)
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7927),
                            Name = "Advertisment",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7931)
                        },
                        new
                        {
                            Id = 4,
                            CreatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7935),
                            Name = "TeamMember",
                            UpdatedOn = new DateTime(2020, 8, 18, 9, 59, 35, 353, DateTimeKind.Local).AddTicks(7939)
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.ApplicationUser", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("PhysicalTherapyProject.Domain.Models.Occupation", "Occupation")
                        .WithMany()
                        .HasForeignKey("OccupationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.Image", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.Post", "Post")
                        .WithMany("Images")
                        .HasForeignKey("PostId");
                });

            modelBuilder.Entity("PhysicalTherapyProject.Domain.Models.Post", b =>
                {
                    b.HasOne("PhysicalTherapyProject.Domain.Models.PostType", "PostType")
                        .WithMany()
                        .HasForeignKey("PostTypeId");

                    b.HasOne("PhysicalTherapyProject.Domain.Models.ApplicationUser", "PostUser")
                        .WithMany("UserPosts")
                        .HasForeignKey("PostUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
