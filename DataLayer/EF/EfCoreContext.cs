using DataLayer.EfClasses;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.EF;

public class EfCoreContext : DbContext
{
    public EfCoreContext(DbContextOptions<EfCoreContext> options)
        : base(options)
    {
    }

    public DbSet<ArticleGroup> ArticleGroups { get; set; }

    public DbSet<Article> Articles { get; set; }

    public DbSet<MealType> MealTypes { get; set; }

    public DbSet<Unit> Units { get; set; }

    public DbSet<Ingredient> Ingredients { get; set; }

    public DbSet<PurchaseItem> PurchaseItems { get; set; }

    public DbSet<Purchase> Purchases { get; set; }

    public DbSet<Recipe> Recipes { get; set; }

    public DbSet<Meal> Meals { get; set; }

    public DbSet<Store> Stores { get; set; }

    public DbSet<ShoppingOrder> ShoppingOrders { get; set; }
}