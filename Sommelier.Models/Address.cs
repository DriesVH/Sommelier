using System;
using System.ComponentModel.DataAnnotations;

namespace Sommelier.Models
{
    public class Address : BaseEntity
    {
        [Required]
        public Zip Zip { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string HouseNumber { get; set; }
        public string FlatNumber { get; set; }
    }
}
