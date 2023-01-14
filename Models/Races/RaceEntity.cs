using System.ComponentModel.DataAnnotations;
using Core;
using Models.Goods;

namespace Models.Races;

public record RaceEntity(
  [property: Key] Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
  string Name, string? Description, string Needs, string Decadency, string Will,
  List<GoodEntity> Products
) : IResource {
  public static RaceEntity From(RaceResource race)
    => new(
      race.Id, race.CreatedAt, race.UpdatedAt,
      race.Name, race.Description, race.Needs, race.Decadency, race.Will,
      new());

  public static RaceEntity From(RaceModel race)
    => new(
      Guid.NewGuid(), DateTime.Now, null,
      race.Name, race.Description, race.Needs, race.Decadency, race.Will
    );

  /// <summary>
  /// EF constructor
  /// </summary>
  private RaceEntity(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, string Needs, string Decadency, string Will
  )
    : this(
      Id, CreatedAt, UpdatedAt,
      Name, Description, Needs, Decadency, Will, new()
    ) { }
}
