using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MeetAndGo.Services
{
    public class BaseReadService<T, TDb, TSearch> : IReadService<T, TSearch> where T : class where TDb : class where TSearch : class
    {
        public meetGoContext _dbContext { get; set; }
        public IMapper _mapper { get; set; }

        public BaseReadService(meetGoContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = _dbContext.Set<TDb>();
            var list = entity.ToList();

            return _mapper.Map<List<T>>(list);
        }

        public virtual T GetById(int id)
        {
            var set = _dbContext.Set<TDb>();
            var entity = set.Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}
