using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Interfaces
{
    public interface IOfficeService : ICRUDService<Model.Office, OfficeSearchObject, OfficeUpsertRequest, OfficeUpsertRequest>
    {
    }
}
