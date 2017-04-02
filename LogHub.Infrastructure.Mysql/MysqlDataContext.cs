using LogHub.Domain.Contract.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LogHub.Infrastructure.Mysql
{
    public class MysqlDataContext : DbContext
    {
        public DbSet<SerilogEvent> SerilogEvents { get; set; }
        public MysqlDataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

    public static class LogHubDbContextOptionFactory
    {
        public static void SetUseMySql(DbContextOptionsBuilder op, string connectionString)
        {
            op.UseMySql(connectionString);
        }
    }
}
