using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Interfaces
{
    public interface IRentedBuildingService : ICRUDService<Model.RentedBuilding, object, object, Model.Requests.RentedBuildingUpdateRequest>
    {
        Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildings();
        Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildingsByUserId(int userId);
    }
}
