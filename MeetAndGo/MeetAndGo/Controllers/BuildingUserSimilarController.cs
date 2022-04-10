using MeetAndGo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class BuildingUserSimilarController : Controller
    {
        private readonly ISimilarBuilding _service;
        public BuildingUserSimilarController(ISimilarBuilding service) { _service = service; }

        [HttpGet("recommended/{id}")]
        public List<Model.Building> GetAllRecommended(int id)
        {
            return _service.GetAll(id);
        }
    }
}