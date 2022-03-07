using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using System.Threading.Tasks;

namespace MeetAndGo.Interfaces
{
    public interface IUserAccountRoleService : ICRUDService<Model.UserAccountRole, UserAccountRoleSearchObject, UserAccountRoleUpsertRequest, UserAccountRoleUpsertRequest>
    {
        Task<Model.UserAccountRole> GetRoleByUserAccountId(int userAccountId);
    }
}
