using DataModels.Races;

namespace DataModels.Goods;

public sealed record GoodResourceWithProducers<T>(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description,
    List<T> Producers)
  : IGood,
    IResource
  where T : IRace;
