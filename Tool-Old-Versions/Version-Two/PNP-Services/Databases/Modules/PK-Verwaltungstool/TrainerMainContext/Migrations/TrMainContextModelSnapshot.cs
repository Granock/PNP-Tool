﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP_Services.Databases.Modules.PK_Verwaltungstool.TrainerMainContext;

namespace PNP_Services.Databases.Modules.PKVerwaltungstool.TrainerMainContext.Migrations
{
    [DbContext(typeof(TrMainContext))]
    partial class TrMainContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("PNP_Services.Databases.Modules.PK_Verwaltungstool.TrainerMainContext.Model.Trainer", b =>
                {
                    b.Property<Guid>("TrainerGUID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.HasKey("TrainerGUID");

                    b.ToTable("Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}