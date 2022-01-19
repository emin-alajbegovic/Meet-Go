using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "SuperAdmin")]
    public class BuildingController : BaseCRUDController<Model.Building, BuildingSearchObject, BuildingUpsertRequest, BuildingUpsertRequest>
    {
        public BuildingController(IBuildingService buildingService)
            : base(buildingService)
        {

        }
    }
}
