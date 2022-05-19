using MeetAndGo.Model.Requests;
using System.Threading.Tasks;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Interfaces
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserUpsertRequest, UserUpsertRequest>
    {
        Task<Model.User> GetUserByUserAccountId(int id);
    }
}