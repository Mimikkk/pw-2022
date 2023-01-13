using DataModels.Races;

namespace DataModels.Goods;

public sealed record GoodResourceWithProducer<T>(
    Guid RaceId, Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description,
    T Producer)
  : GoodResource(RaceId, Id, CreatedAt, UpdatedAt, Name, Description)
  where T : IRace;
