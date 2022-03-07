using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Controllers
{
    public class UserAccountRoleController : BaseCRUDController<Model.UserAccountRole, UserAccountRoleSearchObject, UserAccountRoleUpsertRequest, UserAccountRoleUpsertRequest>
    {
        public UserAccountRoleController(IUserAccountRoleService userAcconutRoleService)
            : base(userAcconutRoleService)
        {

        }
        //[HttpGet("{id}")]
        //public Model.UserAccount GetById(int id)
        //{
        //    return _service.GetById(id);
        //}
    }
}
