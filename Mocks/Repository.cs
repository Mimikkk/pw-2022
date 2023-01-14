using Mockers;
using Models.Goods;
using Models.Races;

namespace Mocks;

internal static class Repository {
  public static readonly List<RaceResourceWithProducts<GoodResource>> RacesWithProducts = new();
  public static IEnumerable<GoodResource> Goods => RacesWithProducts?.SelectMany(x => x.Products) ?? new List<GoodResource>();

  static Repository() {
    var goods = GoodMocker.CreateResources(40).ToList();
    var races = RaceMocker.CreateResourcesWithProducts(8, goods);

    RacesWithProducts = races.ToList();
  }
}
