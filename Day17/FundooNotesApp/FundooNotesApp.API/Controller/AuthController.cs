using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FundooNotesApp.Business.Interfaces;
using FundooNotesApp.Models.DTOs.Request;

namespace FundooNotesApp.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
    
        private readonly IAuthUser _authUser;

        public AuthController(IAuthUser authUser)
        {
            _authUser = authUser;
        }

        // POST: api/auth/register
        [HttpPost("register")]
        public IActionResult Register([FromBody] RegisterDTO registerDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _authUser.RegisterUser(registerDto);

                 if (result == null)
                {
                    return BadRequest(new { success = false, message = "Email is already registered." });
                }

                return Ok(new { success = true, message = "Registration successful.", data = result });
            }

            catch(Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }


        // POST: api/auth/login
         [HttpPost("login")]
         
        public IActionResult Login([FromBody] LoginDTO loginDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = _authUser.LoginUser(loginDto);
                if (result == null)
                {
                    return Unauthorized("Invalid email or password.");
                }

                return Ok(new { success = true, message = "Login successful.", data = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { success = false, message = ex.Message });
            }
        }

         // POST: api/auth/forgot-password

         [HttpPost("forgot-password")]
        public IActionResult ForgotPassword( ForgotPasswordDTO forgotPasswordDTO)
        {
            var result = _authUser.ForgotPassword(
                forgotPasswordDTO
            );

            if (!result)
            {
                return NotFound("User not found.");
            }

            return Ok("Password updated successfully.");
        }
    }
}