using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Trans_system.Domain.Interfaces;
using Trans_system.Infrastructure.DataAccess;

namespace Trans_system.Infrastructure;
public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection service, IConfiguration configuration)
    {
        AddDbContext(service, configuration);
        AddRepositories(service);
    }

    private static void AddDbContext(IServiceCollection service, IConfiguration configuration)
    {
        var mysql_version = new MySqlServerVersion(new Version(8, 0, 36));
        var mysql_connection = configuration.GetConnectionString("MySqlConnection");
        service.AddDbContext<AppDbContext>(x=>x.UseMySql(mysql_version));
    }

    private static void AddRepositories(IServiceCollection service)
    {
        service.AddScoped<ILocationRepository, LocationRepository>();
        service.AddScoped<IPassengerRepository, PassengerRepository>();
        service.AddScoped<IPaymentRepository, PaymentRepository>();
        service.AddScoped<IReservationRepository, ReservationRepository>();
        service.AddScoped<IRouteRepository, RouteRepository>();
        service.AddScoped<ITripRepository, TripRepository>();
        service.AddScoped<IUserRepository, UserRepository>();
        service.AddScoped<IVehicleRepository, VehicleRepository>();
    }

   
}
