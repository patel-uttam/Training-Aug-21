using System;
using System.Collections.Generic;

#nullable disable

namespace Day17Assignment.Models
{
    public partial class DrugTime
    {
        public int? Patient { get; set; }
        public int? Drug { get; set; }
        public bool? Morning { get; set; }
        public bool? Afternoon { get; set; }
        public bool? Evening { get; set; }

        public virtual Drug DrugNavigation { get; set; }
        public virtual Patient PatientNavigation { get; set; }
    }
}
