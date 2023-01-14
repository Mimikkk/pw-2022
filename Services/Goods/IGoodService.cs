using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public interface IGoodService {
  public Task<GoodResource?> Read(Guid id);
  public Task<GoodResource?> Read(string name);
  public Task<GoodResourceWithProducer<RaceResource>?> ReadWithProducer(Guid id);
  public Task<GoodResourceWithProducer<RaceResource>?> ReadWithProducer(string name);
  public Task<IEnumerable<GoodResource>> ReadAll();
  public Task<IEnumerable<GoodResource>> FilterBy(string? name = default);
  public Task<bool> Create(Guid raceId, GoodModel model);
  public Task<bool> Remove(Guid id);
  public Task<bool> Update(Guid id, GoodModel model);
}
