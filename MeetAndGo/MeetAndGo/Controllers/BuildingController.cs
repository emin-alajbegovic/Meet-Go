using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{

    //public class BuildingController : BaseCRUDController<Model.Building, BuildingSearchObject, BuildingUpsertRequest, BuildingUpsertRequest>
    //{
    //    public BuildingController(IBuildingService buildingService)
    //        : base(buildingService)
    //    {

    //    }
    //}

    [ApiController]
    [Authorize]
    [Route("api/[controller]")]

    public class BuildingController : ControllerBase
    {
        private readonly IBuildingService _service;
        public BuildingController(IBuildingService service) { _service = service; }

        [HttpGet]
        public IEnumerable<Model.Building> Get([FromQuery]BuildingSearchObject request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Building GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin,Admin")]
        public Model.Building Insert([FromBody] BuildingUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "SuperAdmin,Admin")]
        public Model.Building Update(int id, [FromBody] BuildingUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "SuperAdmin")]
        public Model.Building Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
