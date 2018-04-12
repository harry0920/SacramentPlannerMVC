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
    [Migration("20180412173604_HymnForeignKeys")]
    partial class HymnForeignKeys
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentPlannerMVC.Models.Bishopric", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Bishopric");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Hymn", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HymnTitle");

                    b.HasKey("ID");

                    b.ToTable("Hymns");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Meeting", b =>
                {
                    b.Property<int>("MeetingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BishopricID");

                    b.Property<int>("ClosingHymnID");

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("Date");

                    b.Property<int?>("IntermediateHymnID");

                    b.Property<int>("OpeningHymnID");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("SacramentHymnID");

                    b.HasKey("MeetingId");

                    b.HasIndex("BishopricID");

                    b.HasIndex("ClosingHymnID");

                    b.HasIndex("IntermediateHymnID");

                    b.HasIndex("OpeningHymnID");

                    b.HasIndex("SacramentHymnID");

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

            modelBuilder.Entity("SacramentPlannerMVC.Models.Speaker", b =>
                {
                    b.HasBaseType("SacramentPlannerMVC.Models.Member");

                    b.Property<int?>("MeetingId");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasIndex("MeetingId");

                    b.ToTable("Speaker");

                    b.HasDiscriminator().HasValue("Speaker");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Meeting", b =>
                {
                    b.HasOne("SacramentPlannerMVC.Models.Bishopric", "Conductor")
                        .WithMany("Meeting")
                        .HasForeignKey("BishopricID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SacramentPlannerMVC.Models.Hymn", "ClosingHymnNav")
                        .WithMany("MeetingClosingHymnNav")
                        .HasForeignKey("ClosingHymnID");

                    b.HasOne("SacramentPlannerMVC.Models.Hymn", "IntermediateHymnNav")
                        .WithMany("MeetingIntermediateHymnNav")
                        .HasForeignKey("IntermediateHymnID");

                    b.HasOne("SacramentPlannerMVC.Models.Hymn", "OpeningHymnNav")
                        .WithMany("MeetingOpeningHymnNav")
                        .HasForeignKey("OpeningHymnID");

                    b.HasOne("SacramentPlannerMVC.Models.Hymn", "SacramentHymnNav")
                        .WithMany("MeetingSacramentHymnNav")
                        .HasForeignKey("SacramentHymnID");
                });

            modelBuilder.Entity("SacramentPlannerMVC.Models.Speaker", b =>
                {
                    b.HasOne("SacramentPlannerMVC.Models.Meeting")
                        .WithMany("Speakers")
                        .HasForeignKey("MeetingId");
                });
#pragma warning restore 612, 618
        }
    }
}