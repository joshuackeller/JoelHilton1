﻿// <auto-generated />
using System;
using JoelHilton1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JoelHilton1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220204205902_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("JoelHilton1.Models.AddMovieModel", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieRatingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<int?>("RatingMovieRatingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RatingMovieRatingId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            CategoryId = 2,
                            Director = "Steven Spielberg",
                            Edited = false,
                            MovieRatingId = 2,
                            Title = "West Side Story",
                            Year = 2021
                        },
                        new
                        {
                            MovieId = 2,
                            CategoryId = 4,
                            Director = "Jason Reitman",
                            Edited = false,
                            MovieRatingId = 2,
                            Title = "Ghostbusters: Afterlife",
                            Year = 2021
                        },
                        new
                        {
                            MovieId = 3,
                            CategoryId = 6,
                            Director = "Jon Watts",
                            Edited = false,
                            MovieRatingId = 2,
                            Title = "Spiderman: No Way Home",
                            Year = 2021
                        });
                });

            modelBuilder.Entity("JoelHilton1.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Sports"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Musical"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fantasy"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Fiction"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Historical"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Science Fiction"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Horror"
                        },
                        new
                        {
                            CategoryId = 8,
                            CategoryName = "Mystery"
                        },
                        new
                        {
                            CategoryId = 9,
                            CategoryName = "Crime"
                        });
                });

            modelBuilder.Entity("JoelHilton1.Models.Rating", b =>
                {
                    b.Property<int>("MovieRatingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieRating")
                        .HasColumnType("TEXT");

                    b.HasKey("MovieRatingId");

                    b.ToTable("ratings");

                    b.HasData(
                        new
                        {
                            MovieRatingId = 1,
                            MovieRating = "G"
                        },
                        new
                        {
                            MovieRatingId = 2,
                            MovieRating = "PG"
                        },
                        new
                        {
                            MovieRatingId = 3,
                            MovieRating = "PG-13"
                        },
                        new
                        {
                            MovieRatingId = 4,
                            MovieRating = "R"
                        });
                });

            modelBuilder.Entity("JoelHilton1.Models.AddMovieModel", b =>
                {
                    b.HasOne("JoelHilton1.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JoelHilton1.Models.Rating", "Rating")
                        .WithMany()
                        .HasForeignKey("RatingMovieRatingId");
                });
#pragma warning restore 612, 618
        }
    }
}