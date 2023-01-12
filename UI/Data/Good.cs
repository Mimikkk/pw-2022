namespace UI.Data;

public interface IGood {
  string Name { get; init; }
  string? Description { get; init; }
}
public record GoodModel(string Name, string? Description)
  : IGood;
public record GoodResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description)
  : IGood,
    IResource;
public record GoodResourceWithProducers(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description,
    List<IRace> Goods)
  : IGood,
    IResource;
