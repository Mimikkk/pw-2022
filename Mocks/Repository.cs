using DataModels.Goods;
using DataModels.Races;
using Mocks.Mockers;

namespace Mocks;

internal static class Repository {
  public static readonly List<RaceResourceWithProducts<GoodResource>> RacesWithProducts;
  public static IEnumerable<GoodResource> Goods => RacesWithProducts.SelectMany(x => x.Products);

  static Repository() {
    var goods = GoodMocker.CreateResources(40);
    var races = RaceMocker.CreateResourcesWithProducts(8, goods);

    RacesWithProducts = races.ToList();
  }
}
