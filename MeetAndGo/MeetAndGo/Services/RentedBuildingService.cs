using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Services
{
    public class RentedBuildingService : CRUDService<Model.RentedBuilding, Database.RentedBuilding, object, object, object>, IRentedBuildingService
    {
        public RentedBuildingService(meetGoContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<IEnumerable<Model.RentedBuilding>> GetAllRentedBuildings()
        {
            var entity = await _dbContext.RentedBuilding.Include("Building").Include("User").Where(x => x.Rented == true).ToListAsync();

            if (entity == null)
                return null;

            return _mapper.Map<IEnumerable<Database.RentedBuilding>, IEnumerable<Model.RentedBuilding>>(entity);
        }
    }
}
