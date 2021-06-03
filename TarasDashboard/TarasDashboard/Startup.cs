using AutoMapper;
using BusinessLogicLayer.AutoHelper;
using BusinessLogicLayer.Services;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.EFRepositories;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TarasDashboard
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddLocalization();
            services.AddHostedService<TimedHostedService>();
            services.AddDbContext<Avrora37Context>(opts => opts.UseSqlServer(Configuration["ConnectionString:SQL31"]));
            services.AddDbContext<ShopsContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:SQL26"]));

            services.AddScoped<ISaleOracleRepository, SaleOracleRepository>();
            services.AddScoped<ISaleStatisticRepository, SaleStatisticRepository>();
            services.AddScoped<ISaleLast30Days_ByRegionRepository, SaleLast30Days_ByRegionRepository>();
            services.AddScoped<IRegionsLocalizationRepository, RegionsLocalizationRepository>();
            services.AddScoped<IShopsRepository, ShopsRepository>();
            services.AddScoped<IBoardService, BoardService>();
            services.AddControllers();
            services.AddControllersWithViews();

            services.AddHostedService<ConsumeScopedServiceHostedService>();
            services.AddScoped<IScopedProcessingService, ScopedProcessingService>();

            MapperConfiguration mapperconfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });
            IMapper mapper = mapperconfig.CreateMapper();
            services.AddSingleton(mapper);

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }
    }
}
