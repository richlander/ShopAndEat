using ServiceLayer.DTO.ArticleGroup;

namespace ServiceLayer
{
    public interface IArticleGroupService
    {
        void Create(NewArticleGroupDto newArticleGroupDto);

        void Delete(DeleteArticleGroupDto deleteArticleGroupDto);
    }
}