﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TGLWebApp.Data;

namespace TGLWebApp.Migrations
{
    [DbContext(typeof(TGLContext))]
    partial class TGLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TGLWebApp.Models.Computer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<double>("Cpu");

                    b.Property<string>("Model");

                    b.Property<double>("Ram");

                    b.Property<Guid>("StudenId");

                    b.Property<Guid?>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Computer");
                });

            modelBuilder.Entity("TGLWebApp.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<string>("LastName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Nit")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("TGLWebApp.Models.Computer", b =>
                {
                    b.HasOne("TGLWebApp.Models.Student")
                        .WithMany("Computers")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
