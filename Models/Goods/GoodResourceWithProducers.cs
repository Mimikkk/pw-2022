using DataModels.Races;

namespace DataModels.Goods;

public sealed record GoodResourceWithProducers<T>(
    Guid RaceId, Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description,
    List<T> Producers)
  : GoodResource(RaceId, Id, CreatedAt, UpdatedAt, Name, Description)
  where T : IRace;
