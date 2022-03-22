using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
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

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPost]
        public Model.Building Insert([FromBody] BuildingUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPut("{id}")]
        public Model.Building Update(int id, [FromBody] BuildingUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpDelete("{id}")]
        public Model.Building Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
