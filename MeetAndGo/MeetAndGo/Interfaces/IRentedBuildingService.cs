using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Interfaces
{
    public interface IRentedBuildingService : ICRUDService<Model.RentedBuilding, object, object, object>
    {
        Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildings();
    }
}
