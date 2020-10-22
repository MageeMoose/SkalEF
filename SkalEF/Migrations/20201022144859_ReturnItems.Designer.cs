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
    [Migration("20201022144859_ReturnItems")]
    partial class ReturnItems
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

                    b.Property<int>("AmountHeadphonesReturned")
                        .HasColumnType("int");

                    b.Property<int>("AmountMobile")
                        .HasColumnType("int");

                    b.Property<int>("AmountMobileReturned")
                        .HasColumnType("int");

                    b.Property<int>("AmountSlippers")
                        .HasColumnType("int");

                    b.Property<int>("AmountSlippersReturned")
                        .HasColumnType("int");

                    b.Property<int>("AmountSocks")
                        .HasColumnType("int");

                    b.Property<int>("AmountSocksReturned")
                        .HasColumnType("int");

                    b.Property<int>("AmountTrousers")
                        .HasColumnType("int");

                    b.Property<int>("AmountTrousersReturned")
                        .HasColumnType("int");

                    b.Property<int>("AmountUnderware")
                        .HasColumnType("int");

                    b.Property<int>("AmountUnderwareReturned")
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

                    b.Property<DateTime>("HeadphoneGiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HeadphoneRetrunDate")
                        .HasColumnType("datetime2");

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

                    b.Property<DateTime>("MobileGiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MobileReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Room")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("Slippers")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SlippersGiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SlippersRetrunDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Socks")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SocksGiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SocksRetrunDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Trouser")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TrouserGiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TrouserReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Underware")
                        .HasColumnType("bit");

                    b.Property<DateTime>("UnderwareGiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UnderwareReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });
#pragma warning restore 612, 618
        }
    }
}
