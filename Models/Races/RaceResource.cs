using Core;

namespace DataModels.Races;

public sealed record RaceResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, Category Needs, Category Decadency, Category Will
  )
  : IRace,
    IResource;
