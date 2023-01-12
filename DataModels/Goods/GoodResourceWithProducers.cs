using DataModels.Races;

namespace DataModels.Goods;

public record GoodResourceWithProducers(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description,
    List<IRace> Producers)
  : IGood,
    IResource;
