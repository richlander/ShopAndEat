using AutoMapper;
using DataLayer.EfClasses;
using ServiceLayer.DTO.ArticleGroup;

namespace ServiceLayer.Infrastructure
{
    public class Mapper
    {
        public IMapper CreateMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.CreateMap<NewArticleGroupDto, ArticleGroup>()
                      .IgnoreAllPropertiesWithAnInaccessibleSetter();
            });
            configuration.AssertConfigurationIsValid();

            return configuration.CreateMapper();
        }
    }
}