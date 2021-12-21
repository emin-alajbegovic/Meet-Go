using MeetAndGo.Interfaces;
using MeetAndGo.Model;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using MeetAndGo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : BaseCRUDController<Model.User, UserSearchObject, UserUpsertRequest, UserUpsertRequest>
    {
        public UserController(IUserService userService)
            : base(userService)
        {

        }
    }
}
