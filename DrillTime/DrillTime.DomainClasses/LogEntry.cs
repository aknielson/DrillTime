using System;

namespace DrillTime.DomainClasses
{
    public class LogEntry
    {

        public int Id { get; set; }
        public DateTime DrillRunDate { get; set; }

        public int DrillId { get; set; }

        public float DrillStartParTime { get; set; }
        public float DrillSEndParTime { get; set; }
        public int DrillTimeSpanSeconds { get; set; }
        public int DrillReps { get; set; }
        public int PreviousLogIdForDrill { get; set; }

        public virtual Drill Drill { get; set; }
        public virtual LogEntry PreviousLogEntry { get; set; }


    }
}

    