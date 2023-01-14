using System.ComponentModel.DataAnnotations;
using DataModels.Races;

namespace DataModels.Goods;

public record GoodEntity(
  Guid ProducerId, [property: Key] Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
  string Name, string? Description,
  RaceEntity Producer
) : IGood, IResource {
  public static GoodEntity From(GoodResourceWithProducer<RaceResource> good)
    => new(good.Producer.Id, good.Id, good.CreatedAt, good.UpdatedAt,
      good.Name, good.Description,
      null!);
}
