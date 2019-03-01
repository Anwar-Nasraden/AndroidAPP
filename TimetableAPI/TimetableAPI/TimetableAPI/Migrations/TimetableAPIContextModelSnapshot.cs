﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimetableAPI.Models;

namespace TimetableAPI.Migrations
{
    [DbContext(typeof(TimetableAPIContext))]
    partial class TimetableAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimetableAPI.Models.Calendar", b =>
                {
                    b.Property<int>("Claendar_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CalendarDate");

                    b.Property<string>("DayofWeek");

                    b.Property<int>("WeekNumber");

                    b.HasKey("Claendar_Id");

                    b.ToTable("Calendar");
                });

            modelBuilder.Entity("TimetableAPI.Models.Room", b =>
                {
                    b.Property<int>("Room_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("Room_no");

                    b.HasKey("Room_Id");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("TimetableAPI.Models.Timetable", b =>
                {
                    b.Property<int>("Timetable_Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CaledarDate");

                    b.Property<int?>("CalendarClaendar_Id");

                    b.Property<DateTime>("EndTime");

                    b.Property<int?>("Room_Id");

                    b.Property<int>("Room_no");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("Timetable_Id");

                    b.HasIndex("CalendarClaendar_Id");

                    b.HasIndex("Room_Id");

                    b.ToTable("Timetable");
                });

            modelBuilder.Entity("TimetableAPI.Models.Timetable", b =>
                {
                    b.HasOne("TimetableAPI.Models.Calendar", "Calendar")
                        .WithMany()
                        .HasForeignKey("CalendarClaendar_Id");

                    b.HasOne("TimetableAPI.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("Room_Id");
                });
#pragma warning restore 612, 618
        }
    }
}