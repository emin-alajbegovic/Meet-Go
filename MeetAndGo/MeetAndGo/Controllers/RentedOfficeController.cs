using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class RentedOfficeController : BaseReadController<Model.RentedOffice, object>
    {
        public RentedOfficeController(IReadService<RentedOffice, object> service) : base(service) { }
    }
}
