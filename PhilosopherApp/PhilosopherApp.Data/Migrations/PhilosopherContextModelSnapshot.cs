﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhilosopherApp.Data;

#nullable disable

namespace PhilosopherApp.Data.Migrations
{
    [DbContext(typeof(PhilosopherContext))]
    partial class PhilosopherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PhilosopherApp.Domain.Discussion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Discussions");
                });

            modelBuilder.Entity("PhilosopherApp.Domain.DiscussionPhilosopher", b =>
                {
                    b.Property<int>("DiscussionId")
                        .HasColumnType("int");

                    b.Property<int>("PhilosopherId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateJoined")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.HasKey("DiscussionId", "PhilosopherId");

                    b.HasIndex("PhilosopherId");

                    b.ToTable("DiscussionPhilosopher");
                });

            modelBuilder.Entity("PhilosopherApp.Domain.Philosopher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Philosophers");
                });

            modelBuilder.Entity("PhilosopherApp.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PhilosopherId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PhilosopherId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("PhilosopherApp.Domain.DiscussionPhilosopher", b =>
                {
                    b.HasOne("PhilosopherApp.Domain.Discussion", null)
                        .WithMany()
                        .HasForeignKey("DiscussionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PhilosopherApp.Domain.Philosopher", null)
                        .WithMany()
                        .HasForeignKey("PhilosopherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PhilosopherApp.Domain.Quote", b =>
                {
                    b.HasOne("PhilosopherApp.Domain.Philosopher", "Philosopher")
                        .WithMany("Quotes")
                        .HasForeignKey("PhilosopherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Philosopher");
                });

            modelBuilder.Entity("PhilosopherApp.Domain.Philosopher", b =>
                {
                    b.Navigation("Quotes");
                });
#pragma warning restore 612, 618
        }
    }
}