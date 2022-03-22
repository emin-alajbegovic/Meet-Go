using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MeetAndGo.Services
{
    public class ReportService : IReportService
    {
        public meetGoContext _dbContext { get; set; }
        public IMapper _mapper { get; set; }
        public ReportService(IMapper mapper, meetGoContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public List<Model.Report.Report> GetReport()
        {
            var query = from u in _dbContext.User
                        join rb in _dbContext.RentedBuilding on u.UserId equals rb.UserId
                        join b in _dbContext.Building on rb.BuildingId equals b.BuildingId
                        join ro in _dbContext.RentedOffice on u.UserId equals ro.UserId
                        join o in _dbContext.Office on ro.OfficeId equals o.OfficeId
                        group new { u, rb, b, ro, o } by new { u.FirstName, u.LastName } into g
                        select new { FirstName = g.Key.FirstName, LastName = g.Key.LastName, TimeRented = g.Count() };

            var entity = query.ToList();
            var list = new List<Model.Report.Report>();

            entity.ForEach(y => list.Add(new Model.Report.Report { FirstName = y.FirstName, LastName = y.LastName, TimeRented = y.TimeRented }));

            return list.ToList();
        }
    }
}
