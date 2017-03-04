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
            var context = new EfData.DrillDbContext();
            var drills = context.Drills.ToList();
            foreach (var drill in drills)
            {
                Console.WriteLine(drill.Name);
            }
        }
    }
}
