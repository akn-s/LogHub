using LogHub.Domain.Contract.Models;
using LogHub.Infrastructure.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogHub.Infrastructure.Mysql.Repositories
{
    public class SerilogEventRepotitory : RepositoryBase<SerilogEvent>, ISerilogEventRepository
    {
        public SerilogEventRepotitory(MysqlDataContext context)
        : base(context)
        { }
    }
}
