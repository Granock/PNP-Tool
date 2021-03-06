// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PNP.Services.Service.Databases.Modules.Pokemon.Contexts;

namespace PNP.Services.Service.Migrations.Trainer
{
    [DbContext(typeof(TrainerContext))]
    partial class TrainerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("PNP.Services.Service.Databases.Modules.Pokemon.Models.TrainerContext.Trainer", b =>
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
