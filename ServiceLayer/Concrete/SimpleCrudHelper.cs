using System.Collections.Generic;
using AutoMapper;
using DataLayer.EF;

namespace ServiceLayer.Concrete
{
    public class SimpleCrudHelper
    {
        public SimpleCrudHelper(EfCoreContext dbContext, IMapper mapper)
        {
            DbContext = dbContext;
            Mapper = mapper;
        }

        private EfCoreContext DbContext { get; }

        private IMapper Mapper { get; }

        public TDtoOut Create<TDtoIn, TIn, TDtoOut>(TDtoIn newDto)
        {
            var mappedObject = Mapper.Map<TDtoIn, TIn>(newDto);
            var addedEntity = DbContext.Add(mappedObject);
            DbContext.SaveChanges();

            return Mapper.Map<TDtoOut>(addedEntity.Entity);
        }

        public void Delete<TIn>(int idToDelete)
            where TIn : class
        {
            var entityToDelete = DbContext.Find<TIn>(idToDelete);
            DbContext.Remove(entityToDelete);
            DbContext.SaveChanges();
        }

        public IEnumerable<TDtoOut> GetAll<TIn, TDtoOut>()
            where TIn : class
        {
            var allEntities = DbContext.Set<TIn>();

            return Mapper.Map<IEnumerable<TDtoOut>>(allEntities);
        }
    }
}