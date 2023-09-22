
using ContosoPizzaApi.Data;
using ContosoPizzaApi.Services;
using Dumpify;
using Microsoft.AspNetCore.OData;

namespace ContosoPizzaApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddControllers().AddOData(options => 
                options.EnableQueryFeatures());
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IPizzaService, PizzaService>();

            builder.Services.AddHttpClient();

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

            //var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
            //using (var scope = scopeFactory.CreateScope())
            //{
            //    var db = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
            //    if (db.Database.EnsureCreated())
            //    {
            //        SeedData.Initialize(db);
            //    }
            //}

            app.CreateDbIfNotExists();

            app.Run();
            
            //app.Dump();
        }
    }
}