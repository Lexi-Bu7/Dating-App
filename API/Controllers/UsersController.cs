using System.Collections.Generic;
using System.Linq;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
           var UsersList = _context.Users.ToList();
           return UsersList;
        }

        [HttpGet("{id}")]

        public ActionResult<AppUser> GetUsers(int id)
        {

            var user = _context.Users.Find(id);

            return user;
        }

    }
}