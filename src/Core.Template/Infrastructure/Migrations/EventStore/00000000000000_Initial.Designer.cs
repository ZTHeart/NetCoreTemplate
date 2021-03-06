﻿// <auto-generated />
using System;
using Core.Template.Infrastructure.Idempotency;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Template.Infrastructure.Migrations.EventStore
{
    /// <summary>
    /// 
    /// </summary>
    [DbContext(typeof(EventSourceContext))]
    [Migration("00000000000000_Initial")]
    partial class Initial
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Template.Infrastructure.Idempotency.ClientRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AggregateId");

                    b.Property<DateTimeOffset>("DateTime");

                    b.Property<string>("Event");

                    b.Property<string>("Name");

                    b.Property<string>("User");

                    b.HasKey("Id");

                    b.ToTable("ClientRequests");
                });
#pragma warning restore 612, 618
        }
    }
}
