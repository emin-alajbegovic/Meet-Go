using System.Collections.Generic;
using System.Threading.Tasks;

namespace MeetAndGo.Interfaces
{

    public interface IRentedOfficeService : ICRUDService<Model.RentedOffice, object, object, object>
    {
        Task<IEnumerable<Model.RentedOffice>> GetAllRentedOffices();
    }
}
