﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using inventory;

namespace inventory.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class EFCoreDemoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("inventory.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<int>("DestinationId");

                    b.Property<int>("DeviceTypeId");

                    b.Property<string>("Name");

                    b.Property<string>("SerialNumber");

                    b.Property<int>("SourceId");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("inventory.DeviceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("SerialNoRegex");

                    b.HasKey("Id");

                    b.ToTable("DeviceTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
