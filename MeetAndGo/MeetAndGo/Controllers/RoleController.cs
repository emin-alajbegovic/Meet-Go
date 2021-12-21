using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class RoleController : BaseReadController<Model.Role, object>
    {
        public RoleController(IReadService<Role, object> service) : base(service) { }
    }
}
