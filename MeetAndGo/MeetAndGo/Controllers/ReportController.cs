using MeetAndGo.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeetAndGo.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _service;
        public ReportController(IReportService service)
        {
            _service = service;
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpGet]
        public List<Model.Report.Report> GetReport()
        {
            return _service.GetReport();
        }
    }
}
