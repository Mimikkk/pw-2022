using DataModels;

namespace Services;

public interface IGoodService {
  public Task<GoodResource> Read(Guid id);
  public Task<GoodResourceWithProducers> ReadWithProducers(Guid id);
  public Task<IEnumerable<GoodResource>> ReadAll();
  public Task<IEnumerable<GoodResourceWithProducers>> ReadAllWithProducers();
  public Task<IEnumerable<GoodResource>> FilterBy(
    string? name, string? decadency, string? needs, string? will
  );
  public Task<IEnumerable<GoodResourceWithProducers>> FilterWithProducersBy(
    string? name, string? decadency, string? needs, string? will
  );
  public Task Save(GoodModel model);
  public Task Delete(Guid id);
  public Task Update(Guid id, GoodModel model);
}
