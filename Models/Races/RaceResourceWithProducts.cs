using DataModels.Goods;

namespace DataModels.Races;

public record RaceResourceWithProducts(
    Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description, string Needs, string Decadency, string Will,
    List<IGood> Products)
  : IRace,
    IResource;
