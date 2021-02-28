using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.DTOs
{
    public class RegisterDto
    {
        [Required]
        public String  Username { get; set; }
        [Required]
        [StringLength(5,MinimumLength =5)]
        public String Password { get; set; }
    }
}
