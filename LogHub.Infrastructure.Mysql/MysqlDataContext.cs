using LogHub.Domain.Contract.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LogHub.Infrastructure.Mysql
{
    public class MysqlDataContext : DbContext
    {
        public DbSet<SerilogEvent> SerilogEvents { get; set; }
        public MysqlDataContext() : base(LogHubDbContextOptionFactory.UseMySql()) { }
        public MysqlDataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }

    public static class LogHubDbContextOptionFactory
    {
        public static DbContextOptions UseMySql()
        {
            var optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseMySql(@"constr");
            return optionsBuilder.Options;
        }
        public static void SetUseMySql(DbContextOptionsBuilder op)
        {
            op.UseMySql(@"constr");
        }
    }
}
