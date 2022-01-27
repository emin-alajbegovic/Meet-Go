using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
    //public class UserController : BaseCRUDController<Model.User, UserSearchObject, UserUpsertRequest, UserUpsertRequest>
    //{
    //    public UserController(IUserService userService)
    //        : base(userService)
    //    {

    //    }
    //}
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController(IUserService service) { _service = service; }

        [HttpGet]
        public IEnumerable<Model.User> Get([FromQuery] UserSearchObject request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.User GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.User Insert([FromBody] UserUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.User Update(int id, [FromBody] UserUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]

        public Model.User Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
