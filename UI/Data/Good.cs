using Interfaces;

namespace UI.Data;

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
    List<IRace> Producers)
  : IGood,
    IResource;
