using Microsoft.EntityFrameworkCore;
using AppetizersAPI.Models;

namespace AppetizerAPI;

public class AppetizerDbContext : DbContext
{
    public AppetizerDbContext(DbContextOptions<AppetizerDbContext> options) : base(options) { }

    public DbSet<Appetizer> Appetizers { get; set; }
    public DbSet<User> Users { get; set; }
}