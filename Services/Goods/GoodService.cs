using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public sealed class GoodService : IGoodService {
  public Task<GoodResource?> Read(Guid id) {
    throw new NotImplementedException();
  }
  public Task<GoodResourceWithProducers<RaceResource>?> ReadWithProducers(Guid id) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResource>> ReadAll() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> ReadAllWithProducers() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResource>> FilterBy(string? name) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> FilterWithProducersBy(string? name) {
    throw new NotImplementedException();
  }
  public Task<bool> Save(Guid raceId, GoodModel model) {
    throw new NotImplementedException();
  }
  public Task<bool> Delete(Guid id) {
    throw new NotImplementedException();
  }
  public Task<bool> Update(Guid id, GoodModel model) {
    throw new NotImplementedException();
  }
}
