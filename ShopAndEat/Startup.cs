using AutoMapper;
using BizLogic;
using BizLogic.Concrete;
using DataLayer.EF;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ServiceLayer;
using ServiceLayer.Concrete;
using Mapper = DTO.Mapper;

namespace ShopAndEat
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            ConfigureShopAndEatServices(services);

            services.AddDbContext<EfCoreContext>(options => options.UseInMemoryDatabase("inMemory"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }

        private static void ConfigureShopAndEatServices(IServiceCollection services)
        {
            services.AddTransient<SimpleCrudHelper>();
            services.AddTransient<IMealService, MealService>();
            services.AddTransient<IGeneratePurchaseItemsForRecipesAction, GeneratePurchaseItemsForRecipesAction>();
            services.AddTransient<IOrderPurchaseItemsByStoreAction, OrderPurchaseItemsByStoreAction>();
            services.AddSingleton<IMapper>(new Mapper().CreateMapper());
        }
    }
}