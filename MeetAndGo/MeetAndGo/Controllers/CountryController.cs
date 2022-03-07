using MeetAndGo.Model;
using MeetAndGo.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : BaseReadController<Model.Country, object>
    {
        public CountryController(IReadService<Country, object> service) : base(service) { }

    }
}
