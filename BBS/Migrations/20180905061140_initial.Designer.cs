﻿// <auto-generated />
using BBS.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BBS.Migrations
{
    [DbContext(typeof(DBcontext))]
    [Migration("20180905061140_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BBS.Models.Roles.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreateDate")
                        .HasColumnName("CreateTime")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LoginDate")
                        .HasColumnName("LoginTime")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasColumnName("role_name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Password")
                        .HasColumnName("pass")
                        .HasColumnType("int");

                    b.Property<string>("RegName")
                        .HasColumnName("reg_name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("role");
                });
#pragma warning restore 612, 618
        }
    }
}
