﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoneyTracker.Infrastructure.Persistence;

namespace MoneyTracker.Infrastructure.Migrations
{
    [DbContext(typeof(MoneyTrackerDbContext))]
    [Migration("20190205220544_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MoneyTracker.Infrastructure.Persistence.Entities.PurchaseEntity", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("CurrencyCode");

                    b.Property<DateTime>("SpentAt");

                    b.HasKey("PurchaseId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("MoneyTracker.Infrastructure.Persistence.Entities.SalaryEntity", b =>
                {
                    b.Property<int>("SalaryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount");

                    b.Property<string>("CurrencyCode");

                    b.Property<DateTime>("ReceivedAt");

                    b.HasKey("SalaryId");

                    b.ToTable("Salaries");
                });
#pragma warning restore 612, 618
        }
    }
}