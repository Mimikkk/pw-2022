using Core;
using DataModels.Goods;

namespace DataModels.Races;

public sealed record RaceResourceWithProducts<T>(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, Category Needs, Category Decadency, Category Will,
    List<T> Products)
  : RaceResource(Id, CreatedAt, UpdatedAt, Name, Description, Needs, Decadency, Will)
  where T : IGood;
