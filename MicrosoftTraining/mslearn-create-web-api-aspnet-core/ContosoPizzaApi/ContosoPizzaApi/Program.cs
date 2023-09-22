
using ContosoPizzaApi.Data;
using ContosoPizzaApi.Services;
using Dumpify;
using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace ContosoPizzaApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddOData(options => 
                options.EnableQueryFeatures().AddRouteComponents("api", GetEdmModel()));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IPizzaService, PizzaService>();

            //builder.Services.AddHttpClient();

            var connectionString = builder.Configuration["ConnectionString"];
            builder.Services.AddSqlServer<PizzaStoreContext>(connectionString);

            //builder.Service.Dump();

            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();


            app.CreateDbIfNotExists();

            app.Run();
            
            //app.Dump();
        }

        public static IEdmModel GetEdmModel()
        {
            var modelBuilder = new ODataConventionModelBuilder();
            modelBuilder.EntitySet<WeatherForecast>("WeatherForecast");
            return modelBuilder.GetEdmModel();
        }
    }
}