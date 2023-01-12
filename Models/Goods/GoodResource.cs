namespace DataModels.Goods;

public record GoodResource(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description)
  : IGood,
    IResource;
