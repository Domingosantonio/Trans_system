using Microsoft.EntityFrameworkCore;
using Trans_system.Domain.Entities;

namespace Trans_system.Infrastructure.DataAccess;
internal class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options): base(options){}

    public DbSet<Location> locations { get; set; }
}
