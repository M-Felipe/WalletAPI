using Microsoft.AspNetCore.Mvc;
using WalletAPI.Data;
using WalletAPI.DTOs;
using WalletAPI.Models;
using WalletAPI.Services;
using WalletAPI.Utils;

namespace WalletAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserService _userService;
        private readonly IConfiguration _configuration;

        public AuthController(UserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }

        [HttpPost("register")]
        public IActionResult Register(RegisterDto registerDto)
        {
            if (string.IsNullOrEmpty(registerDto.Username) || string.IsNullOrEmpty(registerDto.Password))
                return BadRequest("Nome de usuario e senha são necessarios.");

            if (_userService.UserExists(registerDto.Username))
                return BadRequest("Usuario Ja existe.");

            var user = new User
            {
                Username = registerDto.Username,
                PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password),
                Balance = 0
            };

            _userService.AddUser(user);

            return Ok(new { Message = "Usuario registrado com sucesso." });
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var user = _userService.GetUserByUsername(loginDto.Username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, user.PasswordHash))
                return Unauthorized("Nome de usuario ou senha invalidos.");

            var token = JwtUtils.GenerateJwtToken(user, _configuration);
            return Ok(new { Token = token });
        }
    }
}