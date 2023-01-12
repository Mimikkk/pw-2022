using Bogus;
using DataModels.Goods;
using DataModels.Races;
using Mocks.Mockers;
using Services.Goods;

namespace Mocks.Services;

public sealed class MockGoodService : IGoodService {

  public async Task<GoodResource?> Read(Guid id) {
    await Delay();
    
    return Repository.Goods.FirstOrDefault(r => r.Id == id);
  }
  public async Task<GoodResourceWithProducers<RaceResource>?> ReadWithProducers(Guid id) {
    await Delay();

    return GoodMocker.CreateResourceWithProducts(5) with { Id = id };
  }
  public async Task<IEnumerable<GoodResource>> ReadAll() {
    await Delay();

    return GoodMocker.CreateResources(5);
  }
  public async Task<IEnumerable<GoodResourceWithProducers<RaceResource>>>
    ReadAllWithProducers() {
    await Delay();

    return GoodMocker.CreateResourcesWithProducts(5);
  }
  public async Task<IEnumerable<GoodResource>> FilterBy(
    string? name, string? decadency, string? needs, string? will
  ) {
    await Delay();

    return GoodMocker.CreateResources(5);
  }
  public async Task<IEnumerable<GoodResourceWithProducers<RaceResource>>>
    FilterWithProducersBy(string? name, string? decadency, string? needs, string? will) {
    await Delay();

    throw new NotImplementedException();
  }
  public async Task<bool> Save(GoodModel model) {
    await Delay();

    throw new NotImplementedException();
  }
  public async Task<bool> Delete(Guid id) {
    await Delay();

    throw new NotImplementedException();
  }
  public async Task<bool> Update(Guid id, GoodModel model) {
    await Delay();

    throw new NotImplementedException();
  }

  private static Faker Faker { get; } = new();
  private static async Task Delay() => await Task.Delay(Faker.Random.Int(100, 200));
}
