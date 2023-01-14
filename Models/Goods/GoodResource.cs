namespace DataModels.Goods;

public record GoodResource(
    Guid ProducerId, Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description)
  : IGood,
    IResource {
  public static GoodResource From(GoodEntity entity) => 
    new(entity.ProducerId, entity.Id, entity.CreatedAt, entity.UpdatedAt, entity.Name, entity.Description);
}
