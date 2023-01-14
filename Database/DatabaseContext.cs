using Models.Goods;
using Models.Races;

namespace Database;

using Microsoft.EntityFrameworkCore;

public sealed class DatabaseContext : DbContext {
  public DbSet<RaceResource> Races { get; set; } = null!;
  public DbSet<GoodResource> Goods { get; set; } = null!;

  public DatabaseContext(DbContextOptions<DatabaseContext> options)
    : base(options) { }


  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<RaceEntity>()
      .HasMany(race => race.Products)
      .WithOne(producer => producer.Producer)
      .HasForeignKey(producer => producer.ProducerId)

    builder.Entity<RaceEntity>().SeedValues();
  }
}
