using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrillTime.DomainClasses;
using DrillTime.EfData;

namespace DrillTime.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            TalkToEfContext();
            Console.ReadLine();
            TalkViaUnitOfWork();
            Console.ReadLine();
            CreateLogEntry();
            Console.ReadLine();
        }

        private static void CreateLogEntry()
        {
            LogEntry logEntry = new LogEntry
            {
                DrillId = 1,
                DrillReps = 1,
                DrillRunDate = DateTime.Now,
                DrillSEndParTime = 1.4f,
                DrillStartParTime = 1.4f,
                DrillTimeSpanSeconds = 180

            };

            using (var context = new EfData.DrillDbContext())
            {
                context.LogEntries.Add(logEntry);
                context.SaveChanges();
                var data = context.LogEntries.ToList();
                Console.WriteLine(data.FirstOrDefault().DrillTimeSpanSeconds);

            }
        }

        private static void TalkViaUnitOfWork()
        {
            using (var uow = new UnitOfWork())
            {
                Drill drill = uow.Drills.Get(1);
                Console.WriteLine(drill.Procedure);
            }
        }

        private static void TalkToEfContext()
        {
            using (var context = new EfData.DrillDbContext())
            {
                var drills = context.Drills.ToList();
                foreach (var drill in drills)
                {
                    Console.WriteLine(drill.Name);
                }
            }
        }
    }
}
