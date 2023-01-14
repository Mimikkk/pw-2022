using System.ComponentModel.DataAnnotations;
using Core;
using Models.Goods;

namespace Models.Races;

public record RaceEntity(
  [property: Key] Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
  string Name, string? Description, Category Needs, Category Decadency, Category Will,
  List<GoodEntity> Products
) : IRace, IResource {
  public static RaceEntity From(RaceResource race)
    => new(
      race.Id, race.CreatedAt, race.UpdatedAt,
      race.Name, race.Description, race.Needs, race.Decadency, race.Will,
      new());
}
