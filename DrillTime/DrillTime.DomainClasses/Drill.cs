using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillTime.DomainClasses
{
    public class Drill
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string StartPosition { get; set; }
        public string Procedure { get; set; }
       
        public float SuggestedTimeSpan { get; set; }
        public int SuggestedReps { get; set; }


        public float TargetPar { get; set; }
    }
}
