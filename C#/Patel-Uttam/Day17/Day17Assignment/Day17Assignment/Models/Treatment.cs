using System;
using System.Collections.Generic;

#nullable disable

namespace Day17Assignment.Models
{
    public partial class Treatment
    {
        public int? Patient { get; set; }
        public int? Doctor { get; set; }
        public int? Assistant1 { get; set; }
        public int? Assistant2 { get; set; }
        public string Illness { get; set; }
        public string Treatment1 { get; set; }

        public virtual Assistant Assistant1Navigation { get; set; }
        public virtual Assistant Assistant2Navigation { get; set; }
        public virtual Doctor DoctorNavigation { get; set; }
        public virtual Patient PatientNavigation { get; set; }
    }
}
