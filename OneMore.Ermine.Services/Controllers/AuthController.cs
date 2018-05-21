using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OneMore.Ermine.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Auth")]
    public class AuthController : Controller
    {
        public IActionResult Login(string username, string password)
        {

            var token = new JwtSecurityToken();
            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}