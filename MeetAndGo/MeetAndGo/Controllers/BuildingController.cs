using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Mvc;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BuildingController : BaseCRUDController<Model.Building, BuildingSearchObject, BuildingUpsertRequest, BuildingUpsertRequest>
    {
        public BuildingController(IBuildingService buildingService)
            : base(buildingService)
        {

        }
    }
}
