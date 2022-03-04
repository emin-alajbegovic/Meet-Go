using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Services
{
    public class UserAccountRoleService : CRUDService<Model.UserAccountRole, Database.UserAccountRole, UserAccountRoleSearchObject, UserAccountRoleUpsertRequest, UserAccountRoleUpsertRequest>, IUserAccountRoleService
    {
        public UserAccountRoleService(meetGoContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {

        }
    }
}
