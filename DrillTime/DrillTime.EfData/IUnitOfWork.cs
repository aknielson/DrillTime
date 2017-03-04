using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrillTime.DomainClasses;

namespace DrillTime.EfData
{
    public interface IUnitOfWork : IDisposable
    {

        IRepository<Drill> Drills { get; }
        IRepository<LogEntry> LogEntries { get; }

        int Complete();
    }
}
