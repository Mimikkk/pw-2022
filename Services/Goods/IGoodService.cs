using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public interface IGoodService {
  public Task<GoodResource?> Read(Guid id);
  public Task<GoodResourceWithProducers<RaceResource>?> ReadWithProducers(Guid id);
  public Task<IEnumerable<GoodResource>> ReadAll();
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> ReadAllWithProducers();
  public Task<IEnumerable<GoodResource>> FilterBy(string? name);
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> FilterWithProducersBy(string? name);
  public Task<bool> Save(Guid raceId, GoodModel model);
  public Task<bool> Delete(Guid id);
  public Task<bool> Update(Guid id, GoodModel model);
}
