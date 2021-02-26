using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public byte [] PasswordHash { get; set; }
        public Byte[] PasswordSalt { get; set; }
    }
}
