using MeetAndGo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using MeetAndGo.Model.Requests;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class RentedOfficeController : ControllerBase
    {
        private readonly IRentedOfficeService _service;
        public RentedOfficeController(IRentedOfficeService service) { _service = service; }

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("all")]
        public async Task<IEnumerable<Model.RentedOffice>> GetAllRentedOffices()
        {
            return await _service.GetAllRentedOffices();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public Model.RentedOffice GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("{id}")]
        public Model.RentedOffice Update(int id, [FromBody] RentedOfficeUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public Model.RentedOffice Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}
