using Bogus;
using Core;
using Models.Goods;
using Models.Races;

namespace Mockers;

public static class RaceMocker {
  public static Faker<T> ApplyRaceRules<T>(this Faker<T> faker) where T : class, IRace =>
    faker
      .RuleFor(g => g.Name, f => f.Lorem.Word())
      .RuleFor(g => g.Description, f => f.Lorem.Sentences(12))
      .RuleFor(g => g.Decadency, f => f.PickRandom(Category.List as IEnumerable<Category>))
      .RuleFor(g => g.Needs, f => f.PickRandom(Category.List as IEnumerable<Category>))
      .RuleFor(g => g.Will, f => f.PickRandom(Category.List as IEnumerable<Category>));

  public static IEnumerable<RaceResource> CreateResources(int count) =>
    new Faker<RaceResource>().WithRecord().ApplyResourceRules().ApplyRaceRules().Generate(count);

  public static IEnumerable<RaceResourceWithProducts<GoodResource>>
    CreateResourcesWithProducts(int count, IEnumerable<GoodResource> goods) {
     var items = goods.ToList(); 
     
    return new Faker<RaceResourceWithProducts<GoodResource>>()
      .WithRecord()
      .ApplyResourceRules()
      .ApplyRaceRules()
      .RuleFor(
        r => r.Products,
        (f, r) => items
          .Where(_ => f.Random.Bool(5f / items.Count))
          .Select(g => g with { ProducerId = r.Id })
          .ToList()
      )
      .Generate(count);
  }
}
