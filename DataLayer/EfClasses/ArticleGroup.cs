using JetBrains.Annotations;

namespace DataLayer.EfClasses
{
    public class ArticleGroup
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