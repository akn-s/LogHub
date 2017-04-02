using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using LogHub.Infrastructure.Mysql;

namespace LogHub.Infrastructure.Mysql.Migrations
{
    [DbContext(typeof(MysqlDataContext))]
    partial class MysqlDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("LogHub.Domain.Contract.Models.SerilogEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Json");

                    b.Property<string>("Level");

                    b.Property<string>("MessageTemplate");

                    b.Property<string>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("SerilogEvents");
                });
        }
    }
}
