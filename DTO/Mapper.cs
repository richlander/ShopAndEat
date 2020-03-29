using AutoMapper;
using DTO.Article;
using DTO.ArticleGroup;

namespace DTO
{
    public class Mapper
    {
        public IMapper CreateMapper()
        {
            var configuration = new MapperConfiguration(config =>
            {
                config.CreateMap<NewArticleGroupDto, DataLayer.EfClasses.ArticleGroup>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<ExistingArticleGroupDto, DataLayer.EfClasses.ArticleGroup>().IgnoreAllPropertiesWithAnInaccessibleSetter();
                config.CreateMap<NewArticleDto, DataLayer.EfClasses.Article>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            });
            configuration.AssertConfigurationIsValid();

            return configuration.CreateMapper();
        }
    }
}