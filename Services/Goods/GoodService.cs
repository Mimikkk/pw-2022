using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public sealed class GoodService : IGoodService {
  public Task<GoodResource> Read(Guid id) {
    throw new NotImplementedException();
  }
  public Task<GoodResourceWithProducers<RaceResource>> ReadWithProducers(Guid id) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResource>> ReadAll() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>>
    ReadAllWithProducers() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResource>> FilterBy(
    string? name, string? decadency, string? needs, string? will
  ) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>>
    FilterWithProducersBy(string? name, string? decadency, string? needs, string? will) {
    throw new NotImplementedException();
  }
  public Task Save(GoodModel model) {
    throw new NotImplementedException();
  }
  public Task Delete(Guid id) {
    throw new NotImplementedException();
  }
  public Task Update(Guid id, GoodModel model) {
    throw new NotImplementedException();
  }
}
