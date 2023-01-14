using Core;

namespace Models.Races;

public record RaceResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, Category Needs, Category Decadency, Category Will
  )
  : IRace,
    IResource {
  public static RaceResource From(RaceEntity entity)
    => new(
      entity.Id, entity.CreatedAt, entity.UpdatedAt,
      entity.Name, entity.Description, entity.Needs, entity.Decadency, entity.Will
    );
}
