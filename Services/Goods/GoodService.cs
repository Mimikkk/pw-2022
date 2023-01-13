using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public sealed class GoodService : IGoodService {
  public Task<GoodResource?> Read(Guid id) {
    throw new NotImplementedException();
  }
  public Task<GoodResource?> Read(string name) {
    throw new NotImplementedException();
  }
  public Task<GoodResourceWithProducer<RaceResource>?> ReadWithProducer(Guid id) {
    throw new NotImplementedException();
  }
  public Task<GoodResourceWithProducer<RaceResource>?> ReadWithProducer(string name) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResource>> ReadAll() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResource>> FilterBy(string? name) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<GoodResourceWithProducer<RaceResource>>> FilterWithProducerBy(string? name = default) {
    throw new NotImplementedException();
  }
  public Task<bool> Create(Guid raceId, GoodModel model) {
    throw new NotImplementedException();
  }
  public Task<bool> Delete(Guid id) {
    throw new NotImplementedException();
  }
  public Task<bool> Update(Guid id, GoodModel model) {
    throw new NotImplementedException();
  }
}
