﻿using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetAndGo.Services
{
    public class RentedOfficeService : CRUDService<Model.RentedOffice, Database.RentedOffice, object, object, object>, IRentedOfficeService
    {
        public RentedOfficeService(meetGoContext dbContext, IMapper mapper) : base(dbContext, mapper) { }

        public async Task<IEnumerable<Model.RentedOffice>> GetAllRentedOffices()
        {
            var entity = await _dbContext.RentedOffice.Include("Office").Include("User").Where(x => x.Rented == true).ToListAsync();

            if (entity == null)
                return null;

            return _mapper.Map<IEnumerable<Database.RentedOffice>, IEnumerable<Model.RentedOffice>>(entity);
        }
    }

}