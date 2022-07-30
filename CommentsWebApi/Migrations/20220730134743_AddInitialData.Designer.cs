﻿// <auto-generated />
using System;
using CommentsWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CommentsWebApi.Migrations
{
    [DbContext(typeof(CommentContext))]
    [Migration("20220730134743_AddInitialData")]
    partial class AddInitialData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("CommentsWebApi.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ArticleId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Text")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Comment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArticleId = 1,
                            DateTime = new DateTime(2022, 2, 10, 18, 30, 15, 0, DateTimeKind.Unspecified),
                            Text = "Test Text",
                            UserName = "Sergiy"
                        },
                        new
                        {
                            Id = 2,
                            ArticleId = 1,
                            DateTime = new DateTime(2022, 3, 10, 15, 14, 13, 0, DateTimeKind.Unspecified),
                            Text = "Alex's comment",
                            UserName = "Alex"
                        },
                        new
                        {
                            Id = 3,
                            ArticleId = 2,
                            DateTime = new DateTime(2022, 5, 1, 1, 2, 3, 0, DateTimeKind.Unspecified),
                            Text = "I like it",
                            UserName = "Bob"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}