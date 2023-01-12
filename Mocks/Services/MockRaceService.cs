using DataModels.Goods;
using DataModels.Races;
using Services.Races;

namespace Mocks.Services;

public sealed class MockRaceService : MockService, IRaceService {
  public static IRaceService Instance { get; } = new MockRaceService();

  public async Task<RaceResource?> Read(Guid id)
    => await ReadWithProducts(id);
  public async Task<IEnumerable<RaceResource>> ReadAll()
    => await ReadAllWithProducts();
  public async Task<IEnumerable<RaceResource>>
    FilterBy(string? name, string? decadency, string? needs, string? will)
    => await FilterWithProductsBy(name, decadency, needs, will);

  public async Task<RaceResourceWithProducts<GoodResource>?>
    ReadWithProducts(Guid id)
    => (await ReadAllWithProducts()).FirstOrDefault(r => r.Id == id);

  public async Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    FilterWithProductsBy(string? name, string? decadency, string? needs, string? will) {
    var races = await ReadAllWithProducts();

    if (name is not null) races = races.Where(r => r.Name.Contains(name)).ToList();
    if (decadency is not null) races = races.Where(r => r.Decadency.Name.Equals(decadency)).ToList();
    if (needs is not null) races = races.Where(r => r.Needs.Name.Equals(needs)).ToList();
    if (will is not null) races = races.Where(r => r.Will.Name.Equals(will)).ToList();

    return races;
  }

  public async Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    ReadAllWithProducts() {
    await Delay();

    return Repository.RacesWithProducts;
  }

  public async Task<bool> Save(RaceModel model) {
    await Delay();

    Repository.RacesWithProducts.Add(new RaceResourceWithProducts<GoodResource>(
      Guid.NewGuid(),
      DateTime.Now,
      null,
      model.Name,
      model.Description,
      model.Needs,
      model.Decadency,
      model.Will,
      new()
    ));

    return true;
  }
  public async Task<bool> Delete(Guid id) {
    var race = await ReadWithProducts(id);
    if (race?.Products.Count is not 0) return false;

    Repository.RacesWithProducts.Remove(race);
    return true;
  }
  public async Task<bool> Update(Guid id, RaceModel model) {
    var race = await ReadWithProducts(id);
    if (race is null) return false;

    Repository.RacesWithProducts.Remove(race);
    Repository.RacesWithProducts.Add(new RaceResourceWithProducts<GoodResource>(
      id,
      race.CreatedAt,
      DateTime.Now,
      model.Name,
      model.Description,
      model.Decadency,
      model.Needs,
      model.Will,
      race.Products
    ));

    return true;
  }
}
