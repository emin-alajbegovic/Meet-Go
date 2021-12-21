using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class CityController : BaseReadController<Model.City, object>
    {
        public CityController(IReadService<City, object> service) : base(service) { }
    }
}
