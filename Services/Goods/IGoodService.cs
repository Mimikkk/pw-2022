using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public interface IGoodService {
  public Task<GoodResource?> Read(Guid id);
  public Task<GoodResourceWithProducers<RaceResource>?> ReadWithProducers(Guid id);
  public Task<IEnumerable<GoodResource>> ReadAll();
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> ReadAllWithProducers();
  public Task<IEnumerable<GoodResource>> FilterBy(string? name = default);
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> FilterWithProducersBy(string? name = default);
  public Task<bool> Create(Guid raceId, GoodModel model);
  public Task<bool> Delete(Guid id);
  public Task<bool> Update(Guid id, GoodModel model);
}
