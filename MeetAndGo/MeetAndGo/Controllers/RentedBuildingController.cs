using MeetAndGo.Interfaces;
using MeetAndGo.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]
    public class RentedBuildingController : ControllerBase
    {
        private readonly IRentedBuildingService _service;
        public RentedBuildingController(IRentedBuildingService service) { _service = service; }

        [HttpGet("all")]
        [Authorize(Roles = "SuperAdmin,Admin")]
        public async Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildings()
        {
            return await _service.GetAllRentedBuildings();
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public Model.RentedBuilding GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public Model.RentedBuilding Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}