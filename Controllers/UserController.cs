using DatingApp.Data;
using DatingApp.Entites;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UserController :ControllerBase 
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            var Users = _context.appUsers.ToList();
            return Users;

        }
        [HttpGet("{id}")]
  
       public ActionResult <AppUser> GetbyId(int id)
        {
            var user= _context.appUsers.Find(id);
            return user;
        
        }
    }
}
