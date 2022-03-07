using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class TypeOfBuildingController : BaseReadController<Model.TypeOfBuilding, object>
    {
        public TypeOfBuildingController(IReadService<TypeOfBuilding, object> service) : base(service) { }
    }
}
