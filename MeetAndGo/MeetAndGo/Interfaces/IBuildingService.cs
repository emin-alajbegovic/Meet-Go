using MeetAndGo.Model.Requests;
using MeetAndGo.Model.SearchObject;

namespace MeetAndGo.Interfaces
{
    public interface IBuildingService : ICRUDService<Model.Building, BuildingSearchObject, BuildingUpsertRequest, BuildingUpsertRequest>
    {
    }
}
