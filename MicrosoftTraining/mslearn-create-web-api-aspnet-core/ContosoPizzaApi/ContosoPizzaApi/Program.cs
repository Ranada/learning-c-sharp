
using ContosoPizzaApi.Data;
using ContosoPizzaApi.Models;
using ContosoPizzaApi.Services;
using Dumpify;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using System.Security.Claims;

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
            
            var connectionString = builder.Configuration["ConnectionString"];
            builder.Services.AddDbContext<PizzaStoreContext>(x => x.UseSqlServer(connectionString));
            // AddSqlServer is a shortcut version of AddDbContext above, but has less options
            //builder.Services.AddSqlServer<PizzaStoreContext>(connectionString);

            builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
            builder.Services.AddAuthorizationBuilder();

            builder.Services.AddIdentityCore<User>()
                .AddEntityFrameworkStores<PizzaStoreContext>()
                .AddApiEndpoints();

            //builder.Services.AddHttpClient();


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
            
            app.MapIdentityApi<User>();

            app.MapGet("/", (ClaimsPrincipal user) => $"Hello {user.Identity!.Name}")
                .RequireAuthorization();

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