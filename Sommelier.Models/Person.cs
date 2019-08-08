using System;
using System.ComponentModel.DataAnnotations;

namespace Sommelier.Models
{
    public class Person : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        public Address Address { get; set; }
    }
}
