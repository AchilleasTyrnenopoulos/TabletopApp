using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    //our users controller class
    public class UsersController : BaseApiController
    {
        private readonly DataContext _context;

        public UsersController (DataContext context)
        {
            _context = context;
        }

        //GET /users
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            //returns the list of our users from the database
            return await _context.Users.ToListAsync();
        }
        //GET /users/{id}
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
            //returns the user with the given id from the database
            return await _context.Users.FindAsync(id);
        }
    }
}