using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillTime.DomainClasses
{
    public class LogEntry
    {
        public int Id { get; set; }
        public DateTime DrillRunDate { get; set; }
        public virtual Drill DrillId { get; set; }
        public float DrillStartParTime { get; set; }
        public float DrillSEndParTime { get; set; }
        public int DrillTimeSpanSeconds { get; set; }
        public int DrillReps { get; set; }
        public virtual LogEntry PreviousLogEntry { get; set; }

       
    }
}
