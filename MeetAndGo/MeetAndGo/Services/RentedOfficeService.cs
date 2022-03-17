using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Services
{
    public class RentedOfficeService : CRUDService<Model.RentedOffice, Database.RentedOffice, object, object, Model.Requests.RentedOfficeUpdateRequest>, IRentedOfficeService
    {
        public RentedOfficeService(meetGoContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<IEnumerable<Model.RentedOffice>> GetAllRentedOffices()
        {
            var entity = await _dbContext.RentedOffice.Include("Office").Include("User").Where(x => x.Rented == true).ToListAsync();

            if (entity == null)
                return null;

            return _mapper.Map<IEnumerable<Database.RentedOffice>, IEnumerable<Model.RentedOffice>>(entity);
        }

        public override Model.RentedOffice GetById(int rentedOfficeId)
        {
            var entity = _dbContext.RentedOffice.Include("Office").Include("User").FirstOrDefault(x => x.RentedOfficeId == rentedOfficeId);

            if (entity == null)
                return null;

            return _mapper.Map<Model.RentedOffice>(entity);
        }

        public override Model.RentedOffice Update(int rentedOfficeId,Model.Requests.RentedOfficeUpdateRequest request)
        {
            var entity = _dbContext.RentedOffice.FirstOrDefault(x => x.RentedOfficeId == rentedOfficeId);

            if (entity == null)
                return null;

            _mapper.Map(request, entity);

            _dbContext.SaveChanges();

            return _mapper.Map<Model.RentedOffice>(entity);
        }
    }
}
