using AutoMapper;
using MeetAndGo.Database;
using MeetAndGo.Interfaces;

namespace MeetAndGo.Services
{
    public class CRUDService<T, TDb, TSearch, TInsert, TUpdate> : BaseReadService<T, TDb, TSearch>, ICRUDService<T, TSearch, TInsert, TUpdate>
        where T : class where TDb : class where TSearch : class
        where TInsert : class where TUpdate : class
    {
        public CRUDService(meetGoContext _dbContext, IMapper mapper) : base(_dbContext, mapper) { }

        public virtual T Insert(TInsert request)
        {
            var set = _dbContext.Set<TDb>();
            TDb entity = _mapper.Map<TDb>(request);

            set.Add(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate request)
        {
            var set = _dbContext.Set<TDb>();
            var entity = set.Find(id);

            _mapper.Map(request, entity);
            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Delete(int id)
        {
            var set = _dbContext.Set<TDb>();
            var entity = set.Find(id);

            _dbContext.Remove(entity);
            _dbContext.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
