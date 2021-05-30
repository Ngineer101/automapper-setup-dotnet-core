using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NWBlog.AutoMapperDemo.Api.DTOs;
using NWBlog.AutoMapperDemo.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NWBlog.AutoMapperDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMapper _mapper;

        public TestController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Get user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<UserDTO> Get()
        {
            var user = new User
            {
                Id = 1,
                FirstName = "Test user",
                Pets = new List<Pet>
                {
                    new Pet { Id = 1, Type = "Dog" },
                    new Pet { Id = 2, Type = "Cat" },
                    new Pet { Id = 3, Type = "Fish" }
                }
            };

            var userDTO = _mapper.Map<UserDTO>(user);
            return Ok(userDTO);
        }
    }
}
