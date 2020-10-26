﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SkalEF.DB;

namespace SkalEF.Migrations
{
    [DbContext(typeof(ClientContext))]
    partial class ClientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SkalEF.DB.Entity.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("DossNr")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("FoodChoice")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ImgName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Lang")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Room")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Section")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("ClientID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("SkalEF.DB.Entity.ClientItem", b =>
                {
                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ItemInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ItemOutDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ClientID", "ItemID");

                    b.HasIndex("ItemID");

                    b.ToTable("ClientItem");
                });

            modelBuilder.Entity("SkalEF.DB.Entity.ItemModel", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemID");

                    b.ToTable("ItemModel");
                });

            modelBuilder.Entity("SkalEF.DB.Entity.ClientItem", b =>
                {
                    b.HasOne("SkalEF.DB.Entity.Client", "Client")
                        .WithMany("ClientItems")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SkalEF.DB.Entity.ItemModel", "ItemModel")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
