using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Services
{
    public class BuildingService : CRUDService<Model.Building, Database.Building, BuildingSearchObject, BuildingUpsertRequest, BuildingUpsertRequest>, IBuildingService
    {
        public BuildingService(meetGoContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {

        }
        public override IEnumerable<Model.Building> Get(BuildingSearchObject search = null)
        {
            var entity = _dbContext.Set<Database.Building>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Name))
            {
                entity = entity.Where(x => x.Name.Contains(search.Name));
            }

            if (search.TypeOfBuildingId.HasValue)
            {
                entity = entity.Where(x => x.TypeOfBuildingId == search.TypeOfBuildingId);
            }

            if (search?.IncludeTypeOfBuilding == true)
            {
                entity = entity.Include("TypeOfBuilding");
            }

            var list = entity.ToList();

            return _mapper.Map<List<Model.Building>>(list);
        }
    }
}
