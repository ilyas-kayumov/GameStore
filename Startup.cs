using GameStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameStore
{
    public class Startup
    {
        private readonly IConfiguration config;

        public Startup(IConfiguration config)
        {
            this.config = config;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<StoreContext>(options => options.UseSqlServer(connection));

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseMvc(ConfigureRoutes);
        }

        private static void ConfigureRoutes(IRouteBuilder builder)
        {
            builder.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
