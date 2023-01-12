using Bogus;
using Core;
using DataModels.Goods;
using DataModels.Races;

namespace Mocks.Mockers;

internal static class RaceMocker {
  public static Faker<T> ApplyRaceRules<T>(this Faker<T> faker) where T : class, IRace =>
    faker
      .RuleFor(g => g.Name, f => f.Lorem.Word())
      .RuleFor(g => g.Description, f => f.Lorem.Sentences(12))
      .RuleFor(g => g.Decadency, f => f.PickRandom(Category.List as IEnumerable<Category>))
      .RuleFor(g => g.Needs, f => f.PickRandom(Category.List as IEnumerable<Category>))
      .RuleFor(g => g.Will, f => f.PickRandom(Category.List as IEnumerable<Category>));

  public static IRace Create() =>
    new Faker<IRace>().ApplyRaceRules().Generate();

  public static IEnumerable<IRace> CreateMany(int count) =>
    new Faker<IRace>().ApplyRaceRules().Generate(count);

  public static RaceResource CreateResource() =>
    new Faker<RaceResource>().ApplyResourceRules().ApplyRaceRules().Generate();

  public static IEnumerable<RaceResource> CreateResources(int count) =>
    new Faker<RaceResource>().ApplyResourceRules().ApplyRaceRules().Generate(count);

  public static RaceModel CreateModel() =>
    new Faker<RaceModel>().ApplyRaceRules().Generate();

  public static IEnumerable<RaceModel> CreateModels(int count) =>
    new Faker<RaceModel>().ApplyRaceRules().Generate(count);

  public static RaceResourceWithProducts<GoodResource>
    CreateResourceWithProducts(int count) =>
    new Faker<RaceResourceWithProducts<GoodResource>>()
      .ApplyResourceRules()
      .ApplyRaceRules()
      .RuleFor(
        r => r.Products,
        () => GoodMocker.CreateResources(count)
      )
      .Generate();

  public static IEnumerable<RaceResourceWithProducts<GoodResource>>
    CreateResourcesWithProducts(int count, int maxProducts = 5) =>
    new Faker<RaceResourceWithProducts<GoodResource>>()
      .ApplyResourceRules()
      .ApplyRaceRules()
      .RuleFor(
        r => r.Products,
        f => GoodMocker.CreateResources(f.Random.Int(1, maxProducts))
      )
      .Generate(count);

  public static IEnumerable<RaceResourceWithProducts<T>>
    CreateResourcesWithProducts<T>(int count, IEnumerable<T> goods)
    where T : class, IGood =>
    new Faker<RaceResourceWithProducts<T>>()
      .ApplyResourceRules()
      .ApplyRaceRules()
      .RuleFor(
        r => r.Products,
        f => {
          var resources = goods.ToList();

          return resources.Where(_ => f.Random.Bool(10f / resources.Count));
        })
      .Generate(count);
}
