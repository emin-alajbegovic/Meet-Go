using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Interfaces
{
    public interface IUserAccountRoleService : ICRUDService<Model.UserAccountRole, UserAccountRoleSearchObject, UserAccountRoleUpsertRequest, UserAccountRoleUpsertRequest>
    {
    }
}
