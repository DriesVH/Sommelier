using System;
using System.ComponentModel.DataAnnotations;

namespace Sommelier.Models
{
    public class Employee : Person
    {
        [Required]
        public ElmosContract Contract{ get; set; }
        public Account Account { get; set; }
        public EmployeeRole Role { get; set; }
    }
}
