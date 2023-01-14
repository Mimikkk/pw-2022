using Core;
using Models.Goods;

namespace Models.Races;

public sealed record RaceResourceWithProducts<T>(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, Category Needs, Category Decadency, Category Will,
    List<T> Products)
  : RaceResource(Id, CreatedAt, UpdatedAt, Name, Description, Needs, Decadency, Will)
  where T : IGood {
  public new static RaceResourceWithProducts<GoodResource> From(RaceEntity entity)
    => new(
      entity.Id, entity.CreatedAt, entity.UpdatedAt,
      entity.Name, entity.Description, entity.Needs, entity.Decadency, entity.Will,
      entity.Products.Select(GoodResource.From).ToList()
    );
}
