using DataLayer.Core;

namespace DataLayer.EfClasses
{
    public class ArticleGroup : IArticleGroup
    {
        public ArticleGroup(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}