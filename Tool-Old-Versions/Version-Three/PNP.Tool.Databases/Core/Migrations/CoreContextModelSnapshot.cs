﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP.Tool.Databases.Core;

namespace PNP.Tool.Databases.Core.Migrations
{
    [DbContext(typeof(CoreContext))]
    partial class CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("PNP.Tool.Models.Base.HistorieEntry", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("ChangeDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectAfterChange")
                        .HasColumnType("TEXT");

                    b.Property<string>("ObjectBeforChange")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TrackedObjectFK")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("HistorieEntry");
                });

            modelBuilder.Entity("PNP.Tool.Models.Core.SettingEntry", b =>
                {
                    b.Property<Guid>("GUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("SettingName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("GUID");

                    b.ToTable("SettingEntry");
                });
#pragma warning restore 612, 618
        }
    }
}