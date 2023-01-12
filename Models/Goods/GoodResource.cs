namespace DataModels.Goods;

public record GoodResource(
    Guid RaceId, Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description)
  : IGood,
    IResource;
