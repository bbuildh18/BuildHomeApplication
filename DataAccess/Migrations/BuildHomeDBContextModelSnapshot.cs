﻿// <auto-generated />
using System;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(BuildHomeDBContext))]
    partial class BuildHomeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccess.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ItemCategoryCatCode");

                    b.Property<string>("ItemName");

                    b.HasKey("ItemId");

                    b.HasIndex("ItemCategoryCatCode");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("DataAccess.Models.ItemCategory", b =>
                {
                    b.Property<int>("CatCode")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatName");

                    b.HasKey("CatCode");

                    b.ToTable("ItemCategories");
                });

            modelBuilder.Entity("DataAccess.Models.Item", b =>
                {
                    b.HasOne("DataAccess.Models.ItemCategory")
                        .WithMany("Items")
                        .HasForeignKey("ItemCategoryCatCode");
                });
#pragma warning restore 612, 618
        }
    }
}
