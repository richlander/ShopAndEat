using DataLayer.Core;
using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class ArticleGroup : IArticleGroup
    {
        public ArticleGroup(string name)
        {
            Name = name;
        }

        [UsedImplicitly]
        private ArticleGroup()
        {
        }

        public string Name { get; }

        public int ArticleGroupId { get; [UsedImplicitly] private set; }
    }
}