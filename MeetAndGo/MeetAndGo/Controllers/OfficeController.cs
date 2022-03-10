using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
    //public class OfficeController : BaseCRUDController<Model.Office, OfficeSearchObject, OfficeUpsertRequest, OfficeUpsertRequest>
    //{
    //    public OfficeController(IOfficeService officeService)
    //        : base(officeService)
    //    {

    //    }
    //}
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]

    public class OfficeController : ControllerBase
    {
        private readonly IOfficeService _service;
        public OfficeController(IOfficeService service) { _service = service; }

        [HttpGet]
        public IEnumerable<Model.Office> Get([FromQuery] OfficeSearchObject request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Office GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPost]
        public Model.Office Insert([FromBody] OfficeUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpPut("{id}")]
        public Model.Office Update(int id, [FromBody] OfficeUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpDelete("{id}")]
        public Model.Office Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
