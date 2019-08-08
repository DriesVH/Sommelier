using System;
using System.ComponentModel.DataAnnotations;

namespace Sommelier.Models
{
    public class Consultant : Person
    {
        public Specialization Specialization { get; set; }
        [Required]
        public ElmosContract Contract { get; set; }
        public Account Account{ get; set; }
        public Employee AccountManager { get; set; }
    }
}
