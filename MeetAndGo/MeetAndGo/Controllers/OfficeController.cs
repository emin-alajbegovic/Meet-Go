using MeetAndGo.Interfaces;
using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetAndGo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfficeController : BaseCRUDController<Model.Office, OfficeSearchObject, OfficeUpsertRequest, OfficeUpsertRequest>
    {
        public OfficeController(IOfficeService officeService)
            : base(officeService)
        {

        }
    }
}
