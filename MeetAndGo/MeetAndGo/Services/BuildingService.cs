using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
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
    }
}
