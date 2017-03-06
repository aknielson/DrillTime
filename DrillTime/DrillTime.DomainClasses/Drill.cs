using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace DrillTime.DomainClasses
{
    public class Drill
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Drill()
        {
            LogEntries = new HashSet<LogEntry>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(250)]
        public string StartPosition { get; set; }

        public string Procedure { get; set; }

        public int? SuggestedTimeSpan { get; set; }

        public int? SuggestedReps { get; set; }

        public double? TargetPar { get; set; }

        public string Tags { get; set; }
        //public Byte[] DrillImage { get; set; }

        public string DrillImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogEntry> LogEntries { get; set; }
    }
}
