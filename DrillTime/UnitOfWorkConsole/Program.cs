using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrillTime.DomainClasses;
using DrillTime.EfData;

namespace UnitOfWorkConsole
{
    class Program
    {
        static void Main(string[] args)
        {
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
    }
}
