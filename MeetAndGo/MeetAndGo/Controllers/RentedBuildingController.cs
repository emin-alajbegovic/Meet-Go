using MeetAndGo.Interfaces;
using MeetAndGo.Model;
using MeetAndGo.Model.Requests;
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

        [Authorize(Roles = "SuperAdmin,Admin")]
        [HttpGet("user/{userId}")]
        public async Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildingsByUserId(int userId)
        {
            return await _service.GetAllRentedBuildingsByUserId(userId);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("{id}")]
        public Model.RentedBuilding Update(int id, [FromBody] RentedBuildingUpdateRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public Model.RentedBuilding Delete(int id)
        {
            return _service.Delete(id);
        }
    }
}