using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniETicaretAPI.Domain.Entities;
using MiniETicaretAPI.Persistence.Contexts;

namespace MiniETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MiniETicaretCaseAPIDbContext _context;

        public UserController(MiniETicaretCaseAPIDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] User updatedUser)
        {
            var user = await _context.Users.FindAsync(id);

            if (user != null)
            {
                user.Email = updatedUser.Email;
                user.Password = updatedUser.Password;
                user.FullName = updatedUser.FullName;
                user.ProfilePhotoUrl = updatedUser.ProfilePhotoUrl;
                user.Phone = updatedUser.Phone;
                user.Address = updatedUser.Address;
            }

            await _context.SaveChangesAsync();
            if (id != updatedUser.Id)
            {
                throw new Exception("Id is not valid");
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user != null)
                _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}