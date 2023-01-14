using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mockers;
using Models.Races;

namespace Database;

internal static class DatabaseContextSeederExtensions {
  public static void SeedValues(this EntityTypeBuilder<RaceEntity> builder) =>
    builder.HasData(RaceMocker.CreateResources(8).Select(RaceEntity.From));
}
