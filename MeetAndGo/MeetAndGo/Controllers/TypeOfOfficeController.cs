using MeetAndGo.Interfaces;
using MeetAndGo.Model;

namespace MeetAndGo.Controllers
{
    public class TypeOfOfficeController : BaseReadController<Model.TypeOfOffice, object>
    {
        public TypeOfOfficeController(IReadService<TypeOfOffice, object> service) : base(service) { }
    }
}
