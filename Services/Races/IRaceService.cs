using DataModels.Races;

namespace Services.Races;

public interface IRaceService {
  public Task<RaceResource> Read(Guid id);
  public Task<RaceResourceWithProducts> ReadWithProducts(Guid id);
  public Task<IEnumerable<RaceResource>> ReadAll();
  public Task<IEnumerable<RaceResourceWithProducts>> ReadAllWithProducts();
  public Task<IEnumerable<RaceResource>> FilterBy(
    string? name, string? decadency, string? needs, string? will
  );
  public Task<IEnumerable<RaceResourceWithProducts>> FilterWithProductsBy(
    string? name, string? decadency, string? needs, string? will
  );
  public Task Save(RaceModel model);
  public Task Delete(Guid id);
  public Task Update(Guid id, RaceModel model);
}
