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
    public class UserAccountRoleController : ControllerBase
    {
        private readonly IUserAccountRoleService _service;
        public UserAccountRoleController(IUserAccountRoleService service) { _service = service; }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet]
        public IEnumerable<Model.UserAccountRole> Get([FromQuery] UserAccountRoleSearchObject request)
        {
            return _service.Get(request);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("{id}")]
        public Model.UserAccountRole GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("UserAccount/{userAccountId}")]
        public async Task<Model.UserAccountRole> GetByUserAccountId(int userAccountId)
        {
            return await _service.GetRoleByUserAccountId(userAccountId);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPost]
        public Model.UserAccountRole Insert([FromBody] UserAccountRoleUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPut("{id}")]
        public Model.UserAccountRole Update(int id, [FromBody] UserAccountRoleUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpDelete("{id}")]
        public Model.UserAccountRole Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
