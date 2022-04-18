using MeetAndGo.Model;
using MeetAndGo.Interfaces;

namespace MeetAndGo.Controllers
{
    public class CountryController : BaseReadController<Model.Country, object>
    {
        public CountryController(IReadService<Country, object> service) : base(service) { }
    }
}
