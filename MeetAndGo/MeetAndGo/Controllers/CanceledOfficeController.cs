using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class CanceledOfficeController : BaseReadController<Model.CanceledOffice, object>
    {
        public CanceledOfficeController(IReadService<CanceledOffice, object> service) : base(service) { }
    }
}
