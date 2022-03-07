using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class CanceledBuildingController : BaseReadController<Model.CanceledBuilding, object>
    {
        public CanceledBuildingController(IReadService<CanceledBuilding, object> service) : base(service) { }
    }
}
