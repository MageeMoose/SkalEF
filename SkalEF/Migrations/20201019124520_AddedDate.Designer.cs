﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkalEF.Models;

namespace SkalEF.Migrations
{
    [DbContext(typeof(ClientContex))]
    [Migration("20201019124520_AddedDate")]
    partial class AddedDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkalEF.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmountHeadphones")
                        .HasColumnType("int");

                    b.Property<int>("AmountMobile")
                        .HasColumnType("int");

                    b.Property<int>("AmountSlippers")
                        .HasColumnType("int");

                    b.Property<int>("AmountSocks")
                        .HasColumnType("int");

                    b.Property<int>("AmountTrousers")
                        .HasColumnType("int");

                    b.Property<int>("AmountUnderware")
                        .HasColumnType("int");

                    b.Property<string>("CaseOfficer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Dossnr")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirNamn")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Food")
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Headphones")
                        .HasColumnType("bit");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Lang")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LasName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Mobil")
                        .HasColumnType("bit");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Slippers")
                        .HasColumnType("bit");

                    b.Property<bool>("Socks")
                        .HasColumnType("bit");

                    b.Property<bool>("Trouser")
                        .HasColumnType("bit");

                    b.Property<bool>("Underware")
                        .HasColumnType("bit");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}