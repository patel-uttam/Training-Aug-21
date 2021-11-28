using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Day17Practice_Basic_Auth.API.Authentication;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day17Practice_Basic_Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        public AuthenticationController(UserManager<ApplicationUser> userManager , RoleManager<IdentityRole> roleManager , IConfiguration configuration )
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;

        }


/*        // GET: api/<AuthenticationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AuthenticationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AuthenticationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AuthenticationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AuthenticationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/

        [HttpPost]
        [Route("login")]
        
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            var user = await userManager.FindByNameAsync(login.UserName);
            if(user != null && await userManager.CheckPasswordAsync(user,login.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);
                var Authclaim = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name , user.UserName),
                        new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString())
                    };
                foreach(var role in userRoles)
                {
                    Authclaim.Add(new Claim(ClaimTypes.Role ,role));
                }

                var authentication_signin_key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var Token = new JwtSecurityToken(issuer: _configuration["JWT:ValidIssuer"], audience: _configuration["JWT:ValidAudience"], expires: DateTime.Now.AddHours(30) , claims:Authclaim , signingCredentials:new SigningCredentials(authentication_signin_key,SecurityAlgorithms.HmacSha256));

                return Ok(new
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(Token),
                    expiration = Token.ValidTo

                });
            }

            return Unauthorized();
        }


        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] Registration registration)
        {
            var userExists = await userManager.FindByNameAsync(registration.UserName);
            if (userExists != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            }
            ApplicationUser user = new ApplicationUser()
            {
                Email = registration.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registration.UserName
            };
            var result = await userManager.CreateAsync(user, registration.Password);
            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }

        [HttpPost]
        [Route("register-admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] Registration registration)
        {
            var userExists = await userManager.FindByNameAsync(registration.UserName);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User already exists!" });
            
            ApplicationUser user = new ApplicationUser()
            {
                Email = registration.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registration.UserName
            };
            var result = await userManager.CreateAsync(user, registration.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new Response { Status = "Error", Message = "User creation failed! Please check user details and try again." });

            if (!await roleManager.RoleExistsAsync(AuthenticationRole.Admin))
                await roleManager.CreateAsync(new IdentityRole(AuthenticationRole.Admin));
            if (!await roleManager.RoleExistsAsync(AuthenticationRole.User))
                await roleManager.CreateAsync(new IdentityRole(AuthenticationRole.User));

            if (await roleManager.RoleExistsAsync(AuthenticationRole.Admin))
            {
                await userManager.AddToRoleAsync(user, AuthenticationRole.Admin);
            }

            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }
    }
}
