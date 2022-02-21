using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace MeetAndGo.Services
{
    public class UserService : CRUDService<Model.User, Database.User, UserSearchObject, UserUpsertRequest, UserUpsertRequest>, IUserService
    {
        public UserService(meetGoContext dbContext, IMapper mapper) : base(dbContext, mapper) { }
        public override IEnumerable<Model.User> Get(UserSearchObject search = null)
        {
            var entity = _dbContext.Set<Database.User>().AsQueryable();

            if (search.FirstName != null)
            {
                entity = entity.Where(x => x.FirstName.Contains(search.FirstName));
            }

            if (search.LastName != null)
            {
                entity = entity.Where(x => x.LastName.Contains(search.LastName));
            }
            
            var entities = entity.Include(x => x.UserAccount).ToList();
            return _mapper.Map<IEnumerable<Model.User>>(entities);
        }
    }
}
