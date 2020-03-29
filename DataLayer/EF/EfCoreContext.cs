using DataLayer.EfClasses;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.EF
{
    public class EfCoreContext : DbContext
    {
        public EfCoreContext(DbContextOptions<EfCoreContext> options)
            : base(options)
        {
        }

        public DbSet<ArticleGroup> ArticleGroups { get; set; }

        public DbSet<Article> Articles { get; set; }
    }
}