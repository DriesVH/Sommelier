using System;
using System.ComponentModel.DataAnnotations;

namespace Sommelier.Models
{
    public class ElmosContract : BaseEntity
    {
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
