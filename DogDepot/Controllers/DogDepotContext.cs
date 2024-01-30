using Microsoft.EntityFrameworkCore;

namespace DogDepot.Models;

public class DogDepotContext : DbContext
{
  public DbSet<Animal> Animals { get; set; }

  public DbSet<Species> Species { get; set; }
  public DogDepotContext(DbContextOptions options) : base(options) { }
}
