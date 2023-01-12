namespace UI.Data;

public interface IRace {
  string Name { get; init; }
  string? Description { get; init; }
  string Needs { get; init; }
  string Decadency { get; init; }
  string Will { get; init; }
}
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
    List<IGood> Goods)
  : IRace,
    IResource;
