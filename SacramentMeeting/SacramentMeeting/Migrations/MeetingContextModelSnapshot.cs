﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeeting.Data;

#nullable disable

namespace SacramentMeeting.Migrations
{
    [DbContext(typeof(MeetingContext))]
    partial class MeetingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SacramentMeeting.Models.MeetingPlanner", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingSong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductingLeader")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumOfSpeakers")
                        .HasColumnType("int");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningSong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHym")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeakerSubjects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Meeting", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}