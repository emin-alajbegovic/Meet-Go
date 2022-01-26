using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    //public class BuildingController : BaseCRUDController<Model.Building, BuildingSearchObject, BuildingUpsertRequest, BuildingUpsertRequest>
    //{
    //    public BuildingController(IBuildingService buildingService)
    //        : base(buildingService)
    //    {

    //    }
    //}


    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _service;
        public BuildingController(IBuildingService service) { _service = service; }

        [HttpGet]
        [Authorize(Roles = "SuperAdmin")]
        public IEnumerable<Model.Building> Get([FromQuery]BuildingSearchObject request)
        {
            return _service.Get(request);
        }

    }
}
