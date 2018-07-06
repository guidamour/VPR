using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Vue2Spa.Models;
using Vue2Spa.Providers;

namespace Vue2Spa.Controllers
{
    [Produces("application/json")]
    [Route("api/[action]")]
    public class UserController : Controller
    {
        private readonly IUser _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IConfiguration _configuration;

        public UserController(IUser user, UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, IConfiguration configuration)
        {
            _context = user;
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
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
        public async Task<IActionResult> GetUser([FromBody]User user)
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

        [HttpPost]
        public async Task<object> SignIn([FromBody]User u)
        {
            var users = await _context.GetUsers();

            if (users.ToList().Count < 1)
            {
                return BadRequest();
            }

            foreach (User us in users)
            {
                if (us.Email == u.Email)
                {
                    var user = new IdentityUser
                    {
                        UserName = us.Email,
                        Email = us.Email
                    };
                    return await GenerateJwtToken(u.Email, user);
                }
            }

            return NotFound("User does not exist");
        }

        [HttpPost]
        public async Task<object> Register([FromBody] User u)
        {
            var user = new IdentityUser
            {
                UserName = u.Email,
                Email = u.Email
            };
            var result = await _userManager.CreateAsync(user, u.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, false);
                return await GenerateJwtToken(u.Email, user);
            }

            throw new ApplicationException("UNKOWN_ERROR");
        }

        private async Task<object> GenerateJwtToken(string email, IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"]));
            var signInCred = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);
            var expires = DateTime.Now.AddDays(Convert.ToDouble(_configuration["JwtExpireDays"]));
            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtIssuer"],
                claims,
                expires: expires,
                signingCredentials: signInCred
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
