using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Day14Practice.API.Modals
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string DateOFBirth {get; set;}

        public string Gender { get; set; }

        public string CurrentAddress { get; set; }
         
        public string PermanentAddress { get; set; }

        public string City { get; set; }

        public string Nationality { get; set; }

        public string PINCode { get; set; }


    }
}
