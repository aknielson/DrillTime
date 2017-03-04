using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrillTime.DomainClasses;

namespace DrillTime.EfData
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DrillDbContext _context;

        public UnitOfWork(DrillDbContext context)
        {
            _context = context;

            //_context.Configuration.ProxyCreationEnabled = false;

            Drills = new Repository<Drill>(_context);
            LogEntries = new Repository<LogEntry>(_context);
        }

        public UnitOfWork() : this(new DrillDbContext())
        {
        }


        public IRepository<Drill> Drills { get; }
        public IRepository<LogEntry> LogEntries { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
