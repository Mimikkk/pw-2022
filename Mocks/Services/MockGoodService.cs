using DataModels.Goods;
using DataModels.Races;
using Services.Goods;

namespace Mocks.Services;

public sealed class MockGoodService : MockService, IGoodService {
  internal static IGoodService Instance { get; } = new MockGoodService();

  public async Task<GoodResource?> Read(Guid id) {
    await Delay();
    return Repository.Goods.FirstOrDefault(r => r.Id == id);
  }
  public async Task<IEnumerable<GoodResource>> ReadAll() {
    await Delay();
    return Repository.Goods;
  }
  public async Task<IEnumerable<GoodResource>> FilterBy(string? name) {
    await Delay();
    var goods = Repository.Goods;

    if (name is not null) goods = goods.Where(g => g.Name.Contains(name)).ToList();

    return goods;
  }
  public async Task<bool> Save(Guid raceId, GoodModel model) {
    var race = await MockRaceService.Instance.ReadWithProducts(raceId);
    if (race is null) return false;
    race.Products.Add(new GoodResource(
      raceId,
      Guid.NewGuid(),
      DateTime.Now,
      null,
      model.Name,
      model.Description
    ));

    return true;
  }
  public async Task<bool> Delete(Guid id) {
    var good = await Read(id);
    if (good is null) return false;

    Repository.RacesWithProducts
      .Find(x => x.Products.Any(y => y.Id == id))
      ?.Products.Remove(good);

    return true;
  }
  public async Task<bool> Update(Guid id, GoodModel model) {
    var good = await Read(id);
    if (good is null) return false;
    var race = Repository.RacesWithProducts
      .Find(x => x.Products.Any(y => y.Id == id))!;

    race.Products.Remove(good);
    race.Products.Add(new GoodResource(
      race.Id,
      id,
      good.CreatedAt,
      DateTime.Now,
      model.Name,
      model.Description
    ));

    return true;
  }

  public async Task<GoodResourceWithProducers<RaceResource>?>
    ReadWithProducers(Guid id) {
    var producers = Repository.RacesWithProducts.Where(
        r => r.Products.Any(p => p.Id == id)
      )
      .ToList();
    return null;
  }
  public async Task<IEnumerable<GoodResourceWithProducers<RaceResource>>>
    ReadAllWithProducers() {
    await Delay();

    throw new NotImplementedException();
  }
  public async Task<IEnumerable<GoodResourceWithProducers<RaceResource>>>
    FilterWithProducersBy(string? name) {
    await Delay();

    throw new NotImplementedException();
  }
}
