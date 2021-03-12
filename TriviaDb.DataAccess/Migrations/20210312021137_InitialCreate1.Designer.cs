﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriviaDb.DataAccess;

namespace TriviaDb.DataAccess.Migrations
{
    [DbContext(typeof(TriviaDbContext))]
    [Migration("20210312021137_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("TriviaDb.DataAccess.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 9,
                            Name = "General Knowledge"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Entertainment: Books"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Entertainment: Film"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Entertainment: Music"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Entertainment: Musicals & Theatres"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Entertainment: Television"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Entertainment: Video Games"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Entertainment: Board Games"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Science & Nature"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Science: Computers"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Science: Mathematics"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Mythology"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Sports"
                        },
                        new
                        {
                            Id = 22,
                            Name = "Geography"
                        },
                        new
                        {
                            Id = 23,
                            Name = "History"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Politics"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Art"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Celebrities"
                        },
                        new
                        {
                            Id = 27,
                            Name = "Animals"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Vehicles"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Entertainment: Comics"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Science: Gadgets"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Entertainment: Japanese Anime & Manga"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Entertainment: Cartoon & Animations"
                        });
                });

            modelBuilder.Entity("TriviaDb.DataAccess.Models.QuestionAnswers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    b.Property<string>("category")
                        .HasColumnType("text");

                    b.Property<string>("correct_answer")
                        .HasColumnType("text");

                    b.Property<string>("difficulty")
                        .HasColumnType("text");

                    b.Property<string>("incorrect_answers_string")
                        .HasColumnType("text");

                    b.Property<string>("question")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QuestionAnswers");

                    b.HasData(
                        new
                        {
                            Id = -1231208221,
                            category = "Entertainment: Video Games",
                            correct_answer = "False",
                            difficulty = "medium",
                            incorrect_answers_string = "True",
                            question = "Super Mario Bros. was released in 1990.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = -827286599,
                            category = "History",
                            correct_answer = "False",
                            difficulty = "hard",
                            incorrect_answers_string = "True",
                            question = "The Kingdom of Prussia briefly held land in Estonia.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = 1274290027,
                            category = "History",
                            correct_answer = "False",
                            difficulty = "medium",
                            incorrect_answers_string = "True",
                            question = "Sargon II, a king of the Neo-Assyrian Empire, was a direct descendant of Sargon of Akkad.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = 1866955121,
                            category = "Science: Computers",
                            correct_answer = "False",
                            difficulty = "medium",
                            incorrect_answers_string = "True",
                            question = "MacOS is based on Linux.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = -27360051,
                            category = "Entertainment: Video Games",
                            correct_answer = "True",
                            difficulty = "medium",
                            incorrect_answers_string = "False",
                            question = "TF2: The Medic will be credited for an assist if he heals a Spy that successfully saps a building.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = -1698007983,
                            category = "Science: Gadgets",
                            correct_answer = "True",
                            difficulty = "easy",
                            incorrect_answers_string = "False",
                            question = "Microphones can be used not only to pick up sound, but also to project sound similar to a speaker.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = -1993100696,
                            category = "Entertainment: Japanese Anime & Manga",
                            correct_answer = "False",
                            difficulty = "easy",
                            incorrect_answers_string = "True",
                            question = "In the &quot;To Love-Ru&quot; series, Golden Darkness is sent to kill Lala Deviluke.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = -1990943068,
                            category = "History",
                            correct_answer = "False",
                            difficulty = "easy",
                            incorrect_answers_string = "True",
                            question = "The United States of America was the first country to launch a man into space.",
                            type = "boolean"
                        },
                        new
                        {
                            Id = 252581283,
                            category = "General Knowledge",
                            correct_answer = "True",
                            difficulty = "easy",
                            incorrect_answers_string = "False",
                            question = "Slovakia is a member of European Union-",
                            type = "boolean"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}