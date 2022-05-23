using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service) { _service = service; }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet]
        public IEnumerable<Model.User> Get([FromQuery] UserSearchObject request)
        {
            return _service.Get(request);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("{id}")]
        public Model.User GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPost]
        public Model.User Insert([FromBody] UserUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPut("{id}")]
        public Model.User Update(int id, [FromBody] UserUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpDelete("{id}")]
        public Model.User Delete(int id)
        {
            return _service.Delete(id);
        }

        [Authorize]
        [HttpGet("Username/{username}")]
        public async Task<IEnumerable<Model.SearchObject.UserUsernameSearchObject>> GetUserByUserAccountUsername(string username)
        {
            return await _service.GetUserByUserAccountUsername(username);
        }
    }
}
