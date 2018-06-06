using System;
using System.Collections.Generic;
using System.Text;

namespace BinnacleService.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}
