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

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("all")]
        public async Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildings()
        {
            return await _service.GetAllRentedBuildings();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public Model.RentedBuilding Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}