using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class RentedBuildingController : BaseReadController<Model.RentedBuilding, object>
    {
        public RentedBuildingController(IReadService<RentedBuilding, object> service) : base(service) { }
    }
}
