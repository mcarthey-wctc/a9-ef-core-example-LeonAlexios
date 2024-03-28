﻿// <auto-generated />

using EFCoreExample.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreExample.Migrations.Sqlite
{
    [DbContext(typeof(SchoolContextSqlite))]
    partial class SchoolContextSqliteModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("ClassroomStudent", b =>
                {
                    b.Property<int>("ClassroomsClassroomId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentsStudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ClassroomsClassroomId", "StudentsStudentId");

                    b.HasIndex("StudentsStudentId");

                    b.ToTable("ClassroomStudent");
                });

            modelBuilder.Entity("EFCoreExample.Models.Classroom", b =>
                {
                    b.Property<int>("ClassroomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClassroomId");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("EFCoreExample.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ClassroomStudent", b =>
                {
                    b.HasOne("EFCoreExample.Models.Classroom", null)
                        .WithMany()
                        .HasForeignKey("ClassroomsClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreExample.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsStudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
