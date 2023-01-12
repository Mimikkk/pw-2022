using Core;
using DataModels.Goods;

namespace DataModels.Races;

public sealed record RaceResourceWithProducts<T>(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, Category Needs, Category Decadency, Category Will,
    List<T> Products)
  : IRace,
    IResource
  where T : IGood;
