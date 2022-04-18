using MeetAndGo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class OfficeUserSimilarController : Controller
    {
        private readonly ISimilarOffice _service;
        public OfficeUserSimilarController(ISimilarOffice service) { _service = service; }

        [HttpGet("{id}")]
        public List<Model.Office> GetAllRecommended(int id)
        {
            return _service.GetAll(id);
        }
    }
}