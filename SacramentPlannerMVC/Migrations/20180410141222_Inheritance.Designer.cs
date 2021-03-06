﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using SacramentPlannerMVC.Data;
using System;

namespace SacramentPlannerMVC.Migrations
{
    [DbContext(typeof(SacramentContext))]
    [Migration("20180410141222_Inheritance")]
    partial class Inheritance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentPlannerMVC.Models.Hymn", b =>
                {
                    b.Property<int>("HymnID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("hymnNumber");

                    b.Property<string>("hymnTitle");

                    b.HasKey("HymnID");

                    b.ToTable("Hymn");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Meeting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClosingHymn");

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("ConductorID");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("IntermediateHymn");

                    b.Property<int>("OpeningHymn");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("SacramentHymn");

                    b.HasKey("ID");

                    b.HasIndex("ConductorID");

                    b.ToTable("Meeting");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Member");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Member");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Bishopric", b =>
                {
                    b.HasBaseType("SacramentPlannerMVC.Models.Member");

                    b.Property<bool>("IsActive");

                    b.ToTable("Bishopric");

                    b.HasDiscriminator().HasValue("Bishopric");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Speaker", b =>
                {
                    b.HasBaseType("SacramentPlannerMVC.Models.Member");

                    b.Property<int?>("MeetingID");

                    b.Property<int>("MemberID");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasIndex("MeetingID");

                    b.ToTable("Speaker");

                    b.HasDiscriminator().HasValue("Speaker");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Meeting", b =>
                {
                    b.HasOne("SacramentPlannerMVC.Models.Bishopric", "Conductor")
                        .WithMany()
                        .HasForeignKey("ConductorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Speaker", b =>
                {
                    b.HasOne("SacramentPlannerMVC.Models.Meeting")
                        .WithMany("Speakers")
                        .HasForeignKey("MeetingID");
                });
#pragma warning restore 612, 618
        }
    }
}
