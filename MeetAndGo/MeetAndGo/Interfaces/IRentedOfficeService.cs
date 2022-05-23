using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Interfaces
{
    public interface IRentedOfficeService : ICRUDService<Model.RentedOffice, object, Model.Requests.RentedOfficeRequest, Model.Requests.RentedOfficeUpdateRequest>
    {
        Task<IEnumerable<Model.RentedOffice>> GetAllRentedOffices();
        Task<IEnumerable<Model.RentedOffice>> GetAllRentedOfficesByUserId(int userId);
    }
}
