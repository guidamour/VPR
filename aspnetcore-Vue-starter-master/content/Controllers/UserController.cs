using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Models;
using Vue2Spa.Providers;

namespace Vue2Spa.Controllers
{
    [Produces("application/json")]
    [Route("api/login")]
    public class UserController : Controller
    {
        private readonly IUser _context;

        public UserController(IUser user)
        {
            _context = user;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.GetUsers();

            if (users.ToList().Count < 1)
            {
                return BadRequest();
            }

            return Ok(Json(users));
        }

        [HttpGet]
        public async Task<IActionResult> GetUser([FromBody]User u)
        {
            var users = await _context.GetUsers();

            if (users.ToList().Count < 1)
            {
                return BadRequest();
            }

            foreach (User user in users)
            {
                if (user.Email == u.Email)
                {
                    return Ok(Json(user));
                }
            }

            return NotFound("User does not exist");
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody]User user)
        {
            var userFromDb = await _context.GetUsers();

            if (userFromDb.ToList().Count < 1)
            {
                NotFound("No user in the database.");
            }

            foreach (User u in userFromDb.ToList())
            {
                if (u.Email == user.Email && u.Password == user.Password)
                {
                    return Ok(Json(u.Id));
                }
            }

            return NotFound("User not found.");
        }
    }
}
