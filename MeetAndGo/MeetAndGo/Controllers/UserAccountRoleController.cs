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
    }
}
