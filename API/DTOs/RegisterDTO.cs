using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        [MaxLength(20)]
        public required string Username { get; set; }

        [Required]
        [MaxLength(40)]
        public required string Password { get; set; }
    }
}