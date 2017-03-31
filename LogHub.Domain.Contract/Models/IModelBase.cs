using System;
using System.Collections.Generic;
using System.Text;

namespace LogHub.Domain.Contract.Models
{
    public interface IModelBase
    {
        Guid Id { get; set; }
    }
}
