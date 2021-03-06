// <auto-generated />
using DeviceManager_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeviceManager_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220325163653_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("DeviceManager_WebAPI.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Info = "Personal smartphone",
                            Name = "Personal Phone",
                            Status = "Available",
                            Temperature = 28m,
                            Type = "smartphone"
                        },
                        new
                        {
                            Id = 2,
                            Info = "Samsung Tablet",
                            Name = "Work Tablet",
                            Status = "Offline",
                            Temperature = 33m,
                            Type = "tablet"
                        },
                        new
                        {
                            Id = 3,
                            Info = "Company's Computer",
                            Name = "Work Computer",
                            Status = "Available",
                            Temperature = 48m,
                            Type = "computer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
