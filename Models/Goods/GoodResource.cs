namespace DataModels.Goods;

public sealed record GoodResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description)
  : IGood,
    IResource;
