using Models.Races;

namespace Models.Goods;

public sealed record GoodResourceWithProducer<T>(
    Guid ProducerId, Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description,
    T Producer)
  : GoodResource(ProducerId, Id, CreatedAt, UpdatedAt, Name, Description)
  where T : IRace {
  public new static GoodResourceWithProducer<RaceResource> From(GoodEntity entity) =>
    new(entity.ProducerId, entity.Id, entity.CreatedAt, entity.UpdatedAt,
      entity.Name, entity.Description,
      RaceResource.From(entity.Producer)
    );
}
