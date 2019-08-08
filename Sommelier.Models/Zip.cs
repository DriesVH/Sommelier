using System;
using System.ComponentModel.DataAnnotations;

namespace Sommelier.Models
{
    public class Zip : BaseEntity
    {
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
