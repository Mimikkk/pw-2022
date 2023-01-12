using DataModels.Goods;
using DataModels.Races;

namespace Services.Races;

public sealed class RaceService : IRaceService {
  public Task<RaceResource> Read(Guid id) {
    throw new NotImplementedException();
  }
  public Task<RaceResourceWithProducts<GoodResource>> ReadWithProducts(Guid id) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<RaceResource>> ReadAll() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    ReadAllWithProducts() {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<RaceResource>>
    FilterBy(string? name, string? decadency, string? needs, string? will) {
    throw new NotImplementedException();
  }
  public Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    FilterWithProductsBy(string? name, string? decadency, string? needs, string? will) {
    throw new NotImplementedException();
  }
  public Task Save(RaceModel model) {
    throw new NotImplementedException();
  }
  public Task Delete(Guid id) {
    throw new NotImplementedException();
  }
  public Task Update(Guid id, RaceModel model) {
    throw new NotImplementedException();
  }
}
