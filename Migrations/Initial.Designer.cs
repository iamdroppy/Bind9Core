﻿// <auto-generated />
using System;
using BindNineCore.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BindNineCore.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210820054450_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("BindNineCore.Core.Database.Entities.DomainEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Domain")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("DomainService");
                });
#pragma warning restore 612, 618
        }
    }
}
