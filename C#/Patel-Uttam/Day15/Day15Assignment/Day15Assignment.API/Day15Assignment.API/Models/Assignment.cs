using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Day15Assignment.API.Models
{
    public class Assignment
    {
        [Key]
        public int AssignmentId { get; set; }

        
        public string ActionCode { get; set; }

        
        public string ActionReasonCode { get; set; }


        public DateTime ActualTerminationDate { get; set; }

        
        public string AssignmentCategory { get; set; }


        public string AssignmentName { get; set; }

        
        public string AssignmentNumber { get; set; }

        public DateTime AssignmentProjectEndDate { get; set; }

        
        public string AssignmentStatus { get; set; }

        public long AssignmentStatusTypeId { get; set; }

        public long BuisnessUnitID { get; set; }

        public DateTime CreationDate { get; set; }

        public string DefualtExpenseAccount { get; set; }

        public long DepartmentId { get; set; }

        public DateTime EffectiveEndDate { get; set; }

        public DateTime EffectiveStartDate { get; set; }


        public string EndTime { get; set; }

        
        public string Frequency { get; set; }

        
        public string FullPartTime { get; set; }
        public long GradeID { get; set; }
        public long GradeLadderId { get; set; }

        public long JobId { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public long LegalEntityID { get; set; }

        public long LocationID { get; set; }

        public long ManagerAssignmentId { get; set; }
        public long ManagerID { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
