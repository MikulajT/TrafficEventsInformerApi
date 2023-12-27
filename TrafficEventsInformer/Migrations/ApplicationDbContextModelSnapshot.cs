﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrafficEventsInformer.Ef;

#nullable disable

namespace TrafficEventsInformer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RouteEventTrafficRoute", b =>
                {
                    b.Property<string>("EventsId")
                        .HasColumnType("nvarchar(36)");

                    b.Property<int>("TrafficRoutesId")
                        .HasColumnType("int");

                    b.HasKey("EventsId", "TrafficRoutesId");

                    b.HasIndex("TrafficRoutesId");

                    b.ToTable("RouteEventTrafficRoute");
                });

            modelBuilder.Entity("TrafficEventsInformer.Ef.Models.RouteEvent", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(36)
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("EndPointX")
                        .HasColumnType("float");

                    b.Property<double>("EndPointY")
                        .HasColumnType("float");

                    b.Property<bool>("Expired")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("StartPointX")
                        .HasColumnType("float");

                    b.Property<double>("StartPointY")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("RouteEvents");
                });

            modelBuilder.Entity("TrafficEventsInformer.Ef.Models.TrafficRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Coordinates")
                        .IsRequired()
                        .HasColumnType("xml");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TrafficRoutes");
                });

            modelBuilder.Entity("RouteEventTrafficRoute", b =>
                {
                    b.HasOne("TrafficEventsInformer.Ef.Models.RouteEvent", null)
                        .WithMany()
                        .HasForeignKey("EventsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TrafficEventsInformer.Ef.Models.TrafficRoute", null)
                        .WithMany()
                        .HasForeignKey("TrafficRoutesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
