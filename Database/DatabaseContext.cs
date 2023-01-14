using DataModels.Goods;
using DataModels.Races;
using Mocks.Mockers;

namespace Database;

using Microsoft.EntityFrameworkCore;

public class DatabaseContext : DbContext {
  public DbSet<RaceResource> Races { get; set; } = null!;
  public DbSet<GoodResource> Goods { get; set; } = null!;

  public DatabaseContext(DbContextOptions<DatabaseContext> options)
    : base(options) { }


  protected override void OnModelCreating(ModelBuilder builder) {
    base.OnModelCreating(builder);

    builder.Entity<RaceEntity>()
      .HasMany(race => race.Products)
      .WithOne(producer => producer.Producer)
      .HasForeignKey(producer => producer.ProducerId);

    Seed(builder);
  }

  private static void Seed(ModelBuilder builder) =>
    builder.Entity<RaceEntity>()
      .HasData(RaceMocker.CreateResources(8).Select(RaceEntity.From));
}
