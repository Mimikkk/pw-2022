using DataModels.Goods;
using DataModels.Races;

namespace Services.Goods;

public interface IGoodService {
  public Task<GoodResource?> Read(Guid id);
  public Task<GoodResourceWithProducers<RaceResource>?> ReadWithProducers(Guid id);
  public Task<IEnumerable<GoodResource>> ReadAll();
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> ReadAllWithProducers();
  public Task<IEnumerable<GoodResource>> FilterBy(
    string? name, string? decadency, string? needs, string? will
  );
  public Task<IEnumerable<GoodResourceWithProducers<RaceResource>>> FilterWithProducersBy(
    string? name, string? decadency, string? needs, string? will
  );
  public Task<bool> Save(GoodModel model);
  public Task<bool> Delete(Guid id);
  public Task<bool> Update(Guid id, GoodModel model);
}
