using System;

namespace DrillTime.DomainClasses
{
    public class LogEntry
    {

        public int Id { get; set; }
        public DateTime DrillRunDate { get; set; }

        public int DrillId { get; set; }

        public double DrillStartParTime { get; set; }
        public double DrillSEndParTime { get; set; }
        public int DrillTimeSpanSeconds { get; set; }
        public int DrillReps { get; set; }

        public virtual Drill Drill { get; set; }


    }
}

    