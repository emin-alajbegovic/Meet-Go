using MeetAndGo.Model.Requests;
using System.Threading.Tasks;
using MeetAndGo.Model.SearchObject;
using System.Collections.Generic;

namespace MeetAndGo.Interfaces
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserUpsertRequest, UserUpsertRequest>
    {
        Task<IEnumerable<UserUsernameSearchObject>> GetUserByUserAccountUsername(string username);
    }
}