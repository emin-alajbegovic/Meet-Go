using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Services
{
    public class UserAccountRoleService : CRUDService<Model.UserAccountRole, Database.UserAccountRole, UserAccountRoleSearchObject, UserAccountRoleUpsertRequest, UserAccountRoleUpsertRequest>, IUserAccountRoleService
    {
        public UserAccountRoleService(meetGoContext dbContext, IMapper mapper)
            : base(dbContext, mapper) { }

        public async Task<Model.UserAccountRole> GetRoleByUserAccountId(int userAccountId)
        {
            var entity = await _dbContext.UserAccountRole.Where(x => x.UserAccountId == userAccountId).FirstOrDefaultAsync();

            if (entity == null)
                return null;

            return _mapper.Map<Model.UserAccountRole>(entity);
        }
    }
}
