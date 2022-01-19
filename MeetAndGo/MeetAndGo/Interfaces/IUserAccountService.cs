using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using System.Threading.Tasks;

namespace MeetAndGo.Interfaces
{
    public interface IUserAccountService : ICRUDService<Model.UserAccount, UserAccountSearchObject, UserAccountUpsertRequest, UserAccountUpsertRequest>
    {
        Task<Model.UserAccount> Login(string username, string password);
        //Model.UserAccount Register(UserAccountUpsertRequest request);
    }
} 