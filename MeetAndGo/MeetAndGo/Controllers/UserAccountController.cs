using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetAndGo.Controllers
{
    [ApiController]
    //[Authorize]
    [Route("api/[controller]")]
    public class UserAccountController : BaseCRUDController<Model.UserAccount, UserAccountSearchObject, UserAccountUpsertRequest, UserAccountUpsertRequest>
    {
        public UserAccountController(IUserAccountService userAccountService) : base(userAccountService) { }
    }
}
