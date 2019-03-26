﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimetableAPI.Models;

namespace TimetableAPI.Migrations
{
    [DbContext(typeof(TimetableAPIContext))]
    [Migration("20190326164643_AzureMIgration2")]
    partial class AzureMIgration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimetableAPI.Models.Calendar", b =>
                {
                    b.Property<int>("Calendar_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CalendarDate");

                    b.Property<string>("DayofWeek");

                    b.Property<int>("WeekNumber");

                    b.HasKey("Calendar_Id");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("TimetableAPI.Models.Room", b =>
                {
                    b.Property<int>("Room_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsBusy");

                    b.Property<int>("Room_no");

                    b.HasKey("Room_Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("TimetableAPI.Models.Timetable", b =>
                {
                    b.Property<int>("Timetable_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calendar_Id");

                    b.Property<DateTime>("EndTime");

                    b.Property<int>("Room_Id");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Timetable_Id");

                    b.HasIndex("Calendar_Id");

                    b.HasIndex("Room_Id");

                    b.ToTable("Timetable");
                });

            modelBuilder.Entity("TimetableAPI.Models.Timetable", b =>
                {
                    b.HasOne("TimetableAPI.Models.Calendar", "Calendar")
                        .WithMany()
                        .HasForeignKey("Calendar_Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TimetableAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("Room_Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}