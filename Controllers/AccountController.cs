using DatingApp.Data;
using DatingApp.DTOs;
using DatingApp.Entities;
using DatingApp.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly ITokenService itokenServivce;

        private readonly DataContext Context;

        public AccountController(DataContext context,ITokenService itokenServivce)
        {
            Context = context;
            this.itokenServivce = itokenServivce;
        }
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register
            (RegisterDto registerDto)
        {
            if (await UserExits(registerDto.Username)) return BadRequest("UserName is Already Taken");
            using var hmac = new HMACSHA512();
            var user = new AppUser()
            {
                UserName = registerDto.Username.ToLower(),
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(registerDto.Password)),
                PasswordSalt = hmac.Key
            };
            Context.Users.Add(user);
            await Context.SaveChangesAsync();
            return new UserDto
            {
                Usaname = user.UserName,
                Token = itokenServivce.CreateToken(user)
            };
        }

        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            var user= await Context.Users.FirstOrDefaultAsync(x => x.UserName == loginDto.Username.ToLower());
            
            if (user == null)
            {
                return Unauthorized("Invalid Username");
            }
            return new UserDto
            {
                Usaname = user.UserName,
                Token = itokenServivce.CreateToken(user)
            };
        }

        private async Task<bool> UserExits(String Username)
        {
            return await Context.Users.AnyAsync(x => x.UserName == Username.ToLower());
        }
    }
}
