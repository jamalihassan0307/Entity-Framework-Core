using System;
using System.ComponentModel.DataAnnotations;

namespace Entity_Framework_Core_test.Models
{
    public class User
    {
        [Key] // Primary key annotation
        public int Id { get; set; }

        [Required]
        [StringLength(50)] // Example of a maximum length constraint
        public string Name { get; set; }

        [Required]
        //[EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [StringLength(100)]
        public string Address { get; set; }
    }
}
