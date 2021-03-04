﻿using AutoMapper;
using DatingApp.Data;
using DatingApp.DTOs;
using DatingApp.Entities;
using DatingApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DatingApp.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UsersController(IUserRepository userRepository,IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task< ActionResult <IEnumerable<MemberDto>> >GetUsers()
        {
            return Ok(await userRepository.GetMembersAsync());
            
        }

        [HttpGet("{username}")]
        public async Task< ActionResult<MemberDto>> GetUser(string username)
        {
            return await userRepository.GetMemberAsync(username);
        }
    }
}