namespace ContosoPizzaApi.Data;

public static class Extensions
{
    public static void CreateDbIfNotExists(this IHost host)
    {
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var db = services.GetRequiredService<PizzaStoreContext>();
                db.Database.EnsureCreated();
                SeedData.Initialize(db);
            }
        }
    }
}
