using LogHub.Domain.Contract.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogHub.Infrastructure.Contract.Repositories
{
    public interface ISerilogEventRepository : IRepositoryBase<SerilogEvent> { }
}
