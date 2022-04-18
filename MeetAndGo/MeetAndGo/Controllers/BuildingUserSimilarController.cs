using MeetAndGo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class BuildingUserSimilarController : Controller
    {
        private readonly ISimilarBuilding _service;
        public BuildingUserSimilarController(ISimilarBuilding service) { _service = service; }

        [HttpGet("{id}")]
        public List<Model.Building> GetAllRecommended(int id)
        {
            return _service.GetAll(id);
        }
    }
}