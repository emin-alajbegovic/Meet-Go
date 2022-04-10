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
    public class OfficeService : CRUDService<Model.Office, Database.Office, OfficeSearchObject, OfficeUpsertRequest, OfficeUpsertRequest>, IOfficeService
    {
        public OfficeService(meetGoContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {

        }

        public override IEnumerable<Model.Office> Get(OfficeSearchObject search = null)
        {
            var entity = _dbContext.Set<Database.Office>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                entity = entity.Where(x => x.Name.ToLower().Contains(search.Name));
            }

            if (search.TypeOfOfficeId.HasValue)
            {
                entity = entity.Where(x => x.TypeOfOfficeId == search.TypeOfOfficeId);
            }

            if (search?.IncludeTypeOfOffice == true)
            {
                entity = entity.Include("TypeOfOffice");
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Office>>(list);
        }
    }
}
