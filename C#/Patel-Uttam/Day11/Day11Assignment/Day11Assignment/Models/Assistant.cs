using System;
using System.Collections.Generic;

#nullable disable

namespace Day11Assignment.Models
{
    public partial class Assistant
    {
        public int AssistantId { get; set; }
        public string AssistantName { get; set; }
        public int? Department { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
    }
}
