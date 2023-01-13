using DataModels.Goods;
using DataModels.Races;

namespace Services.Races;

public interface IRaceService {
  public Task<RaceResource?> Read(Guid id);
  public Task<RaceResource?> Read(string name);
  public Task<RaceResourceWithProducts<GoodResource>?> ReadWithProducts(Guid id);
  public Task<RaceResourceWithProducts<GoodResource>?> ReadWithProducts(string name);
  public Task<IEnumerable<RaceResource>> ReadAll();
  public Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    ReadAllWithProducts();
  public Task<IEnumerable<RaceResource>> FilterBy(
    string? name = default, string? decadency = default, string? needs = default, string? will = default
  );
  public Task<IEnumerable<RaceResourceWithProducts<GoodResource>>> FilterWithProductsBy(
    string? name = default, string? decadency = default, string? needs = default, string? will = default
  );
  public Task<bool> Create(RaceModel model);
  public Task<bool> Remove(Guid id);
  public Task<bool> Update(Guid id, RaceModel model);
}
