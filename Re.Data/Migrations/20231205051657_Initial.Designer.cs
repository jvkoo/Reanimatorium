﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Re.Data;

#nullable disable

namespace Re.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231205051657_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Re.Core.Models.ArteriaIndications", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("AllowControl")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowPiccoMonitoring")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowPressureMonitoring")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ArteriaIndications");
                });

            modelBuilder.Entity("Re.Core.Models.CentralVeinIndications", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<bool>("AllowHemocorrection")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowInfusionTherapy")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowParenteralNutrition")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowVenoseAccess")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("CentralVeinIndications");
                });

            modelBuilder.Entity("Re.Core.Models.Doctor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Doctor");
                });

            modelBuilder.Entity("Re.Core.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ArtPresDown")
                        .HasColumnType("integer");

                    b.Property<int>("ArtPresUp")
                        .HasColumnType("integer");

                    b.Property<string>("FIO")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Peculiarity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Pulse")
                        .HasColumnType("integer");

                    b.Property<int>("SpO2")
                        .HasColumnType("integer");

                    b.Property<string>("VAS")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Re.Core.Models.SLRProtocol", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AdditionalInfo")
                        .HasColumnType("text");

                    b.Property<string>("CallTo")
                        .HasColumnType("text");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string[]>("DefibrillationInfo")
                        .HasColumnType("text[]");

                    b.Property<string>("DoctorId")
                        .HasColumnType("text");

                    b.Property<string>("EKGMonitor")
                        .HasColumnType("text");

                    b.Property<string>("Features")
                        .HasColumnType("text");

                    b.Property<string[]>("IntravenousCatheterInfo")
                        .HasColumnType("text[]");

                    b.Property<int>("PatientAge")
                        .HasColumnType("integer");

                    b.Property<string>("PatientName")
                        .HasColumnType("text");

                    b.Property<string>("PupilCondition")
                        .HasColumnType("text");

                    b.Property<string>("PupilType")
                        .HasColumnType("text");

                    b.Property<string>("ReanimationCancelReason")
                        .HasColumnType("text");

                    b.Property<string>("ReanimationFeatures")
                        .HasColumnType("text");

                    b.Property<string>("SpontaneousBreathing")
                        .HasColumnType("text");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time without time zone");

                    b.Property<int>("TrachealIntubationNo")
                        .HasColumnType("integer");

                    b.Property<int>("TrachealIntubationTry")
                        .HasColumnType("integer");

                    b.Property<string>("VentilationThrough")
                        .HasColumnType("text");

                    b.Property<string>("VentilationWith")
                        .HasColumnType("text");

                    b.Property<bool>("WasBaseSLRCarriedOut")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("SLRProtocols");
                });

            modelBuilder.Entity("Re.Core.Models.StandardProtocol", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("CatheterInsertedCentimetres")
                        .HasColumnType("integer");

                    b.Property<string>("CatheterUsed")
                        .HasColumnType("text");

                    b.Property<string[]>("CathetersUsed")
                        .HasColumnType("text[]");

                    b.Property<string>("Complications")
                        .HasColumnType("text");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DoctorId")
                        .HasColumnType("text");

                    b.Property<string>("Features")
                        .HasColumnType("text");

                    b.Property<bool>("IsLocalAnesthesyNeeded")
                        .HasColumnType("boolean");

                    b.Property<decimal>("LocalAnesthesyDose")
                        .HasColumnType("numeric");

                    b.Property<string>("LocalAnesthesyType")
                        .HasColumnType("text");

                    b.Property<string[]>("LocalAnesthesyTypes")
                        .HasColumnType("text[]");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<TimeOnly>("Time")
                        .HasColumnType("time without time zone");

                    b.Property<int>("TriesNo")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.ToTable("Protocols");

                    b.HasDiscriminator<string>("Discriminator").HasValue("StandardProtocol");
                });

            modelBuilder.Entity("Re.Core.Models.ArteriaProtocol", b =>
                {
                    b.HasBaseType("Re.Core.Models.StandardProtocol");

                    b.Property<string>("ArteriaToBeCatheterized")
                        .HasColumnType("text");

                    b.Property<string[]>("ArteriasToBeCatheterized")
                        .HasColumnType("text[]");

                    b.Property<string>("IndicationsId")
                        .HasColumnType("text")
                        .HasColumnName("ArteriaProtocol_IndicationsId");

                    b.HasIndex("IndicationsId");

                    b.HasDiscriminator().HasValue("ArteriaProtocol");
                });

            modelBuilder.Entity("Re.Core.Models.CentralVeinProtocol", b =>
                {
                    b.HasBaseType("Re.Core.Models.StandardProtocol");

                    b.Property<int>("CVD")
                        .HasColumnType("integer");

                    b.Property<string>("IndicationsId")
                        .HasColumnType("text");

                    b.Property<bool>("IsRgControlNeeded")
                        .HasColumnType("boolean");

                    b.Property<DateOnly>("RgControlDate")
                        .HasColumnType("date");

                    b.Property<string>("VeinToBeCatheterized")
                        .HasColumnType("text");

                    b.Property<string[]>("VeinsToBeCatheterized")
                        .HasColumnType("text[]");

                    b.HasIndex("IndicationsId");

                    b.HasDiscriminator().HasValue("CentralVeinProtocol");
                });

            modelBuilder.Entity("Re.Core.Models.SLRProtocol", b =>
                {
                    b.HasOne("Re.Core.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Re.Core.Models.StandardProtocol", b =>
                {
                    b.HasOne("Re.Core.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("Re.Core.Models.ArteriaProtocol", b =>
                {
                    b.HasOne("Re.Core.Models.ArteriaIndications", "Indications")
                        .WithMany()
                        .HasForeignKey("IndicationsId");

                    b.Navigation("Indications");
                });

            modelBuilder.Entity("Re.Core.Models.CentralVeinProtocol", b =>
                {
                    b.HasOne("Re.Core.Models.CentralVeinIndications", "Indications")
                        .WithMany()
                        .HasForeignKey("IndicationsId");

                    b.Navigation("Indications");
                });
#pragma warning restore 612, 618
        }
    }
}
