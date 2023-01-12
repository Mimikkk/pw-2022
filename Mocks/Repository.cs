using DataModels.Goods;
using DataModels.Races;
using Mocks.Mockers;
using Services.Goods;

namespace Mocks;

internal static class Repository {
  public static IEnumerable<GoodResource> Goods { get; }
    = GoodMocker.CreateResources(250);
  public static IEnumerable<RaceResourceWithProducts<GoodResource>> Races { get; }
    = RaceMocker.CreateResourcesWithProducts(6, Goods);
}
