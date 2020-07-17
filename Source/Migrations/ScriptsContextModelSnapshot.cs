﻿// <auto-generated />
using System;
using Codenation.Challenge;
using Codenation.Challenge.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Source.Migrations
{
    [DbContext(typeof(ScriptsContext))]
    partial class ScriptsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Codenation.Challenge.Quote", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Actor")
                        .HasColumnName("actor");

                    b.Property<string>("Character")
                        .HasColumnName("character");

                    b.Property<string>("Detail")
                        .HasColumnName("detail")
                        .HasMaxLength(1000);

                    b.Property<int>("Episode")
                        .HasColumnName("episode");

                    b.Property<string>("EpisodeName")
                        .HasColumnName("episode_name");

                    b.Property<DateTime?>("RecordDate")
                        .HasColumnName("record_date");

                    b.Property<string>("Segment")
                        .HasColumnName("segment");

                    b.Property<string>("Series")
                        .HasColumnName("series");

                    b.Property<DateTime?>("TransmissionDate")
                        .HasColumnName("transmission_date");

                    b.Property<string>("Type")
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.ToTable("scripts");
                });
#pragma warning restore 612, 618
        }
    }
}