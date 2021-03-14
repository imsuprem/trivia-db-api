﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriviaDb.DataAccess;

namespace TriviaDb.DataAccess.Migrations
{
    [DbContext(typeof(TriviaDbContext))]
    [Migration("20210314154940_IC3")]
    partial class IC3
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

                    b.Property<string>("imageId")
                        .HasColumnType("text");

                    b.Property<string>("incorrect_answers_string")
                        .HasColumnType("text");

                    b.Property<string>("question")
                        .HasColumnType("text");

                    b.Property<string>("type")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QuestionAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}