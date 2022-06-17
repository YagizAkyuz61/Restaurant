using Api.Data;
using Api.Model;
using AuthenticationPlugin;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private RestaurantDbContext _krDbContext;
        private IConfiguration _configuration;
        private readonly AuthService _auth;

        public AccountController(IConfiguration configuration, RestaurantDbContext ReDbContext)
        {
            _krDbContext = ReDbContext;
            _configuration = configuration;
            _auth = new AuthService(_configuration);
        }

        [HttpPost]
        public IActionResult Register([FromBody] WaiterClass waiter)
        {
            var userWithSameNickname = _krDbContext.WaiterTable.Where(w => w.Nickname == waiter.Nickname).SingleOrDefault();
            if (userWithSameNickname != null)
            {
                return BadRequest("User with same nickname already exists");
            }

            var waiterObj = new WaiterClass()
            {
                Name = waiter.Name,
                Surname = waiter.Surname,
                Nickname = waiter.Nickname,
                Password = SecurePasswordHasherHelper.Hash(waiter.Password),
                Gender = waiter.Gender
            };
            _krDbContext.WaiterTable.Add(waiterObj);
            _krDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPost]
        public IActionResult Login([FromBody] WaiterClass waiter)
        {
            var userNickName = _krDbContext.WaiterTable.FirstOrDefault(w => w.Nickname == waiter.Nickname);
            if (userNickName == null)
            {
                return NotFound();
            }
            if (!SecurePasswordHasherHelper.Verify(waiter.Password, userNickName.Password))
            {
                return Unauthorized();
            }
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Email, waiter.Nickname),
                new Claim(ClaimTypes.Email, waiter.Nickname),
            };
            var token = _auth.GenerateAccessToken(claims);
            return new ObjectResult(new
            {
                access_token = token.AccessToken,
                expires_in = token.ExpiresIn,
                token_type = token.TokenType,
                creation_Time = token.ValidFrom,
                expiration_Time = token.ValidTo,
                waiter_id = userNickName.Id,
                waiter_Name = userNickName.Name,
                waiter_NickName = userNickName.Nickname
            });
        }
    }
}
