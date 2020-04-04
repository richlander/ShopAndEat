using System;
using DataLayer.EF;
using DataLayer.EfClasses;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ShopAndEat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            CreateDbIfNotExists(host);

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
        }

        private static void CreateDbIfNotExists(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            try
            {
                var context = services.GetRequiredService<EfCoreContext>();
                // context.Database.EnsureCreated();
                DbInitializer.Initialize(context);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occurred creating the DB.");
            }
        }

        private static class DbInitializer
        {
            public static void Initialize(EfCoreContext context)
            {
                context.Database.EnsureCreated();

                var lunch = new MealType("Lunch");
                var dinner = new MealType("dinner");
                context.MealTypes.Add(lunch);
                context.MealTypes.Add(dinner);
                context.SaveChanges();

                var piece = new Unit("Piece");
                var pack = new Unit("Pack");
                context.Units.AddRange(piece, pack);
                context.SaveChanges();

                var vegetables = new ArticleGroup("Vegetables");
                var pastaArticleGroup = new ArticleGroup("Pasta");
                context.ArticleGroups.AddRange(vegetables, pastaArticleGroup);
                context.SaveChanges();

                var tomato = new Article("Tomato", vegetables, false);
                var pasta = new Article("Pasta", pastaArticleGroup, true);
                context.Articles.AddRange(tomato, pasta);
                context.SaveChanges();

                var tomatoIngredient = new Ingredient(tomato, 2, piece);
                var pastaIngredient = new Ingredient(pasta, 1, pack);
                context.Ingredients.AddRange(tomatoIngredient, pastaIngredient);
                context.SaveChanges();

                var soup = new Recipe("Soup", 2, new[] { tomatoIngredient });
                var pastaRecipe = new Recipe("Pasta", 1, new[] { pastaIngredient });
                context.Recipes.AddRange(soup, pastaRecipe);
                context.SaveChanges();

                var meal1 = new Meal(DateTime.Now, lunch, soup);
                var meal2 = new Meal(DateTime.Now, dinner, pastaRecipe);
                context.Meals.AddRange(meal1, meal2);
                context.SaveChanges();
            }
        }
    }
}