using MovieStore.Data;
using MovieStore.Data.Repositories;
using MovieStore.Data.Services;

namespace MovieStore.Extensions
{
  public static class ServiceExtensions
  {
    public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddSqlServer<AppDbContext>(configuration.GetConnectionString("DefaultConnection"));
    }

    public static void ConfigureServiceManager(this IServiceCollection services) =>
      services.AddScoped<IDataServices, DataServices>();

    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
      services.AddScoped<IRepositoryManager, RepositoryManager>();

  }
}
