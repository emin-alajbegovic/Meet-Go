using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Interfaces
{
    public interface IUserService : ICRUDService<Model.User, UserSearchObject, UserUpsertRequest, UserUpsertRequest>
    {
    }
}
