using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace  fixit.DTO
{
    public class RegistrationDto
    {
        [Required]
        public int RegistrationId { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}