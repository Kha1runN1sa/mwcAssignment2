﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using mwcAssignment2.Models;
using System;

namespace mwcAssignment2.Migrations
{
    [DbContext(typeof(mwcAssignment2Context))]
    [Migration("20180411032431_AddDateColumn")]
    partial class AddDateColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mwcAssignment2.Models.Blog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Article");

                    b.Property<string>("Author");

                    b.Property<DateTime>("Date");

                    b.HasKey("ID");

                    b.ToTable("Blog");
                });
#pragma warning restore 612, 618
        }
    }
}