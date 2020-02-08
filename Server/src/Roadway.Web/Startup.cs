using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Roadway.Core.Cars;
using Roadway.Data.Contexts;
using Roadway.Data.Repositories;
using Roadway.Domain.Aggregates.Cars;
using Roadway.Domain.Aggregates.Customers;
using Roadway.Domain.Contracts;

namespace Roadway.Web
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

            services.AddDbContext<RoadwayContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            ConfigureDependencies(services);
        }

        private void ConfigureDependencies(IServiceCollection services)
        {
            services.AddScoped<DbContext, RoadwayContext>();
            services.AddScoped(typeof(IBaseRepository<>), typeof(EfRepository<>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICarRepository, CarRepository>();
            services.AddScoped<ICarService, CarService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}