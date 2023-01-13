using Bogus;
using DataModels.Goods;

namespace Mocks.Mockers;

public static class GoodMocker {
  public static Faker<T> ApplyGoodRules<T>(this Faker<T> faker) where T : class, IGood =>
    faker
      .RuleFor(g => g.Name, f => f.Commerce.ProductName())
      .RuleFor(g => g.Description, f => f.Commerce.ProductDescription());

  public static IEnumerable<GoodResource> CreateResources(int count) =>
    new Faker<GoodResource>().WithRecord().ApplyResourceRules().ApplyGoodRules().Generate(count);
}
