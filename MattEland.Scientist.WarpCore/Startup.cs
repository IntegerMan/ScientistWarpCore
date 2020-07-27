using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MattEland.Scientist.WarpCore.ServiceLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace MattEland.Scientist.WarpCore
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
            services.AddControllers();

            services.AddSingleton<IWarpCoreServiceLayer, WarpCoreServiceLayer>();
            services.AddSingleton<IWarpCoilInductionService, WarpCoilInductionService>();
            services.AddSingleton<IDeflectorServiceLayer, DeflectorServiceLayer>();
            services.AddSingleton<INacelleServiceLayer, NacelleServiceLayer>();
            services.AddSingleton<IWarpFieldCalculator, WesleyCrusherWarpFieldCalculator>(); // Uh oh
            services.AddSingleton<IStarship, GalaxyClassStarship>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Force the application to start up the starship by requesting the starship
            app.ApplicationServices.GetService<IStarship>();
        }
    }
}
