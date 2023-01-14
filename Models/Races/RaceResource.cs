using Core;

namespace Models.Races;

public record RaceResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, string Needs, string Decadency, string Will
  )
  : IRace,
    IResource {
  public static RaceResource From(RaceEntity entity)
    => new(
      entity.Id, entity.CreatedAt, entity.UpdatedAt,
      entity.Name, entity.Description, entity.Needs, entity.Decadency, entity.Will
    );
}
