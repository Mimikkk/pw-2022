using Interfaces;

namespace UI.Data;

public record RaceModel(string Name, string? Description, string Needs, string Decadency, string Will)
  : IRace;
public record RaceResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, string Needs, string Decadency, string Will
  )
  : IRace,
    IResource;
public record RaceResourceWithProducts(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, string Needs, string Decadency, string Will,
    List<IGood> Products)
  : IRace,
    IResource;
