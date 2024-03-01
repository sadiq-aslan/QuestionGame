﻿// <auto-generated />
using System;
using Game.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Game.Persistence.Migrations
{
    [DbContext(typeof(GameContext))]
    [Migration("20240301061618_ma")]
    partial class ma
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Game.Domain.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<int>("IsTrue")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6616),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 1,
                            Value = "1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7482),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 1,
                            Value = "2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7493),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 1,
                            Value = "3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7496),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 1,
                            Value = "4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7498),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 2,
                            Value = "1"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7502),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 2,
                            Value = "992"
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7505),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 2,
                            Value = "123"
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7507),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 2,
                            Value = "18"
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7509),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 3,
                            Value = "18"
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7512),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 3,
                            Value = "121"
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7515),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 3,
                            Value = "56"
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7517),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 3,
                            Value = "5kmk"
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7519),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 4,
                            Value = "1"
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7521),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 4,
                            Value = "2"
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7523),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 4,
                            Value = "3"
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7526),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 4,
                            Value = "100"
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7528),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 5,
                            Value = "1000"
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7531),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 5,
                            Value = "1001"
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7534),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 5,
                            Value = "1002"
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7536),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 5,
                            Value = "1008"
                        },
                        new
                        {
                            Id = 21,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7538),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 6,
                            Value = "-3"
                        },
                        new
                        {
                            Id = 22,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7540),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 6,
                            Value = "-5"
                        },
                        new
                        {
                            Id = 23,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7543),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 6,
                            Value = "-32"
                        },
                        new
                        {
                            Id = 24,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7545),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 6,
                            Value = "-39"
                        },
                        new
                        {
                            Id = 25,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7547),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 7,
                            Value = "-0.54"
                        },
                        new
                        {
                            Id = 26,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7549),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 7,
                            Value = "-64"
                        },
                        new
                        {
                            Id = 27,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7552),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 7,
                            Value = "-0.44"
                        },
                        new
                        {
                            Id = 28,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7554),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 7,
                            Value = "-0.541"
                        },
                        new
                        {
                            Id = 29,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7556),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 8,
                            Value = "11"
                        },
                        new
                        {
                            Id = 30,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7558),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 8,
                            Value = "10"
                        },
                        new
                        {
                            Id = 31,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7560),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 8,
                            Value = "19"
                        },
                        new
                        {
                            Id = 32,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7563),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 8,
                            Value = "18"
                        },
                        new
                        {
                            Id = 33,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7565),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 9,
                            Value = "480"
                        },
                        new
                        {
                            Id = 34,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7568),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 9,
                            Value = "300"
                        },
                        new
                        {
                            Id = 35,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7570),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 9,
                            Value = "250"
                        },
                        new
                        {
                            Id = 36,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7573),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 9,
                            Value = "400"
                        },
                        new
                        {
                            Id = 37,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7575),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 10,
                            Value = "32, 45"
                        },
                        new
                        {
                            Id = 38,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7577),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 10,
                            Value = "30, 48"
                        },
                        new
                        {
                            Id = 39,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7579),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 10,
                            Value = "24, 40"
                        },
                        new
                        {
                            Id = 40,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7582),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 10,
                            Value = "25, 49"
                        },
                        new
                        {
                            Id = 41,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7584),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 11,
                            Value = "13"
                        },
                        new
                        {
                            Id = 42,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7586),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 11,
                            Value = "12"
                        },
                        new
                        {
                            Id = 43,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7589),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 11,
                            Value = "14"
                        },
                        new
                        {
                            Id = 44,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7591),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 11,
                            Value = "11"
                        },
                        new
                        {
                            Id = 45,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7593),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 12,
                            Value = "11"
                        },
                        new
                        {
                            Id = 46,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7595),
                            EntityStatus = 1,
                            IsTrue = 1,
                            QuestionId = 12,
                            Value = "0"
                        },
                        new
                        {
                            Id = 47,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7597),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 12,
                            Value = "46"
                        },
                        new
                        {
                            Id = 48,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7600),
                            EntityStatus = 1,
                            IsTrue = 0,
                            QuestionId = 12,
                            Value = "45"
                        });
                });

            modelBuilder.Entity("Game.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 190, DateTimeKind.Local).AddTicks(649),
                            EntityStatus = 1,
                            Name = "Math"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4418),
                            EntityStatus = 1,
                            Name = "History"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4446),
                            EntityStatus = 1,
                            Name = "Geograpy"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4449),
                            EntityStatus = 1,
                            Name = "litrature"
                        });
                });

            modelBuilder.Entity("Game.Domain.Entities.DifficultyLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("DifficultyLevels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(4865),
                            Difficulty = "Easy",
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(5143),
                            Difficulty = "Medium",
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(5150),
                            Difficulty = "Hard",
                            EntityStatus = 1
                        });
                });

            modelBuilder.Entity("Game.Domain.Entities.Gamer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AskedQuestions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gamers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(7937),
                            EntityStatus = 1,
                            UserName = "Sadiq"
                        });
                });

            modelBuilder.Entity("Game.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DifficultLevelId")
                        .HasColumnType("int");

                    b.Property<int>("EntityStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DifficultLevelId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Content = "2*2",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(5472),
                            DifficultLevelId = 1,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Content = "2*9",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6171),
                            DifficultLevelId = 1,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Content = "7*8",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6181),
                            DifficultLevelId = 1,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Content = "sin^2a+cos^2a = ?",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6248),
                            DifficultLevelId = 2,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Content = "888 + 88 + 8 + 8 + 8  ?",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6251),
                            DifficultLevelId = 2,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Content = "-15+ (-5x) =0",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6263),
                            DifficultLevelId = 2,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Content = "1.92÷3",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6265),
                            DifficultLevelId = 2,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Content = "121 Divided by 11 is ",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6268),
                            DifficultLevelId = 3,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Content = " 60 Times of 8 Equals to ",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6270),
                            DifficultLevelId = 3,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Content = "Find the Missing Term in Multiples 6, 12, 18, 24, _, 36, 42, _ 54, 60.",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6273),
                            DifficultLevelId = 3,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Content = " What is the Next Prime Number after 7 ?",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6275),
                            DifficultLevelId = 3,
                            EntityStatus = 1
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Content = "The Product of 131 × 0 × 300 × 4",
                            CreatedDate = new DateTime(2024, 3, 1, 7, 16, 18, 192, DateTimeKind.Local).AddTicks(6278),
                            DifficultLevelId = 3,
                            EntityStatus = 1
                        });
                });

            modelBuilder.Entity("Game.Domain.Entities.Answer", b =>
                {
                    b.HasOne("Game.Domain.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Game.Domain.Entities.Question", b =>
                {
                    b.HasOne("Game.Domain.Entities.Category", "Category")
                        .WithMany("Questions")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Game.Domain.Entities.DifficultyLevel", "DifficultyLevel")
                        .WithMany("Questions")
                        .HasForeignKey("DifficultLevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("DifficultyLevel");
                });

            modelBuilder.Entity("Game.Domain.Entities.Category", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Game.Domain.Entities.DifficultyLevel", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("Game.Domain.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}