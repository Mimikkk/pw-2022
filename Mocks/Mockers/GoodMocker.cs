using Bogus;
using DataModels.Goods;
using DataModels.Races;

namespace Mocks.Mockers;

internal static class GoodMocker {
  public static Faker<T> ApplyGoodRules<T>(this Faker<T> faker) where T : class, IGood =>
    faker
      .RuleFor(g => g.Name, f => f.Commerce.ProductName())
      .RuleFor(g => g.Description, f => f.Commerce.ProductDescription());

  public static IGood Create() =>
    new Faker<IGood>().ApplyGoodRules().Generate();

  public static IEnumerable<IGood> CreateMany(int count) =>
    new Faker<IGood>().ApplyGoodRules().Generate(count);

  public static GoodResource CreateResource() =>
    new Faker<GoodResource>().ApplyResourceRules().ApplyGoodRules().Generate();

  public static IEnumerable<GoodResource> CreateResources(int count) =>
    new Faker<GoodResource>().ApplyResourceRules().ApplyGoodRules().Generate(count);

  public static GoodModel CreateModel() =>
    new Faker<GoodModel>().ApplyGoodRules().Generate();

  public static IEnumerable<GoodModel> CreateModels(int count) =>
    new Faker<GoodModel>().ApplyGoodRules().Generate(count);

  public static GoodResourceWithProducers<RaceResource>
    CreateResourceWithProducts(int count) =>
    new Faker<GoodResourceWithProducers<RaceResource>>()
      .ApplyResourceRules()
      .ApplyGoodRules()
      .RuleFor(
        r => r.Producers,
        () => RaceMocker.CreateResources(count)
      )
      .Generate();

  public static GoodResourceWithProducers<T>
    CreateResourceWithProducts<T>(int count, IEnumerable<T> products)
    where T : class, IRace =>
    new Faker<GoodResourceWithProducers<T>>()
      .ApplyResourceRules()
      .ApplyGoodRules()
      .RuleFor(
        r => r.Producers,
        f => products.Where(_ => f.Random.Bool())
      )
      .Generate();

  public static IEnumerable<GoodResourceWithProducers<RaceResource>>
    CreateResourcesWithProducts(int count, int maxProducts = 5) =>
    new Faker<GoodResourceWithProducers<RaceResource>>()
      .ApplyResourceRules()
      .ApplyGoodRules()
      .RuleFor(
        r => r.Producers,
        f => RaceMocker.CreateResources(f.Random.Int(1, maxProducts))
      )
      .Generate(count);

  public static IEnumerable<GoodResourceWithProducers<T>>
    CreateResourcesWithProducts<T>(int count, IEnumerable<T> products)
    where T : class, IRace =>
    new Faker<GoodResourceWithProducers<T>>()
      .ApplyResourceRules()
      .ApplyGoodRules()
      .RuleFor(
        r => r.Producers,
        f => {
          var resources = products.ToList();

          return resources.Where(_ => f.Random.Bool(10f / resources.Count));
        })
      .Generate(count);
}
