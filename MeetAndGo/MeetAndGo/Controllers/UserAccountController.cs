using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Controllers
{
    //public class UserAccountController : BaseCRUDController<Model.UserAccount, UserAccountSearchObject, UserAccountUpsertRequest, UserAccountUpsertRequest>
    //{
    //    public UserAccountController(IUserAccountService userAccountService) : base(userAccountService) { }
    //}
    [ApiController]
    [Route("api/[controller]")]
    public class UserAccountController : ControllerBase
    {
        private readonly IUserAccountService _service;
        public UserAccountController(IUserAccountService service) { _service = service; }

        [Authorize]
        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet]
        public IEnumerable<Model.UserAccount> Get([FromQuery] UserAccountSearchObject request)
        {
            return _service.Get(request);
        }

        [Authorize]
        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("Username/{username}")]
        public async Task<Model.UserAccount> GetByUsername(string username)
        {
            return await _service.GetUserAccountByUsername(username);
        }

        [Authorize]
        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("{id}")]
        public Model.UserAccount GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.UserAccount Insert([FromBody] UserAccountUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize]
        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPut("{id}")]
        public Model.UserAccount Update(int id, [FromBody] UserAccountUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpDelete("{id}")]
        public Model.UserAccount Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}