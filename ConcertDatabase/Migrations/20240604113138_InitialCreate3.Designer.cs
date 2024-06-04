﻿// <auto-generated />
using System;
using ConcertDatabase.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConcertDatabase.Migrations
{
    [DbContext(typeof(MusicDbContext))]
    [Migration("20240604113138_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConcertDatabase.Entities.Artist", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            ID = new Guid("00000000-0000-0000-0000-000000000001"),
                            Description = "The Beatles were an English rock band formed in Liverpool in 1960. With a line-up comprising John Lennon, Paul McCartney, George Harrison and Ringo Starr, they are regarded as the most influential band of all time.",
                            Name = "The Beatles"
                        },
                        new
                        {
                            ID = new Guid("00000000-0000-0000-0000-000000000002"),
                            Description = "The Rolling Stones are an English rock band formed in London in 1962. The first settled line-up consisted of Brian Jones (guitar, harmonica), Ian Stewart (piano), Mick Jagger (lead vocals, harmonica), Keith Richards (guitar), Bill Wyman (bass) and Charlie Watts (drums).",
                            Name = "The Rolling Stones"
                        },
                        new
                        {
                            ID = new Guid("00000000-0000-0000-0000-000000000003"),
                            Description = "Metallica is an American heavy metal band. The band was formed in 1981 in Los Angeles by vocalist/guitarist James Hetfield and drummer Lars Ulrich, and has been based in San Francisco for most of its career.",
                            Name = "Metallica"
                        },
                        new
                        {
                            ID = new Guid("00000000-0000-0000-0000-000000000004"),
                            Description = "AC/DC are an Australian rock band formed in Sydney in 1973 by Scottish-born brothers Malcolm and Angus Young. Although their music has been variously described as hard rock, blues rock, and heavy metal, the band themselves call it simply 'rock and roll'.",
                            Name = "AC/DC"
                        },
                        new
                        {
                            ID = new Guid("00000000-0000-0000-0000-000000000005"),
                            Description = "U2 are an Irish rock band from Dublin, formed in 1976. The group consists of Bono (lead vocals and rhythm guitar), the Edge (lead guitar, keyboards, and backing vocals), Adam Clayton (bass guitar), and Larry Mullen Jr. (drums and percussion).",
                            Name = "U2"
                        });
                });

            modelBuilder.Entity("ConcertDatabase.Entities.Concert", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ArtistID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Venue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ArtistID");

                    b.ToTable("Concerts");
                });

            modelBuilder.Entity("ConcertDatabase.Entities.Concert", b =>
                {
                    b.HasOne("ConcertDatabase.Entities.Artist", "Artist")
                        .WithMany("Concerts")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("ConcertDatabase.Entities.Artist", b =>
                {
                    b.Navigation("Concerts");
                });
#pragma warning restore 612, 618
        }
    }
}
