namespace DataModels.Races;

public record RaceResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, string Needs, string Decadency, string Will
  )
  : IRace,
    IResource;
