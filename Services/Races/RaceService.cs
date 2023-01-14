using Database;
using Microsoft.EntityFrameworkCore;
using Models.Goods;
using Models.Races;

namespace Services.Races;

public sealed class RaceService : IRaceService {
  public async Task<RaceResource?> Read(Guid id) {
    var race = _context.Races.FirstOrDefault(x => x.Id == id);
    return race is null ? null : RaceResource.From(race);
  }
  public async Task<RaceResource?> Read(string name) {
    var race = _context.Races.FirstOrDefault(x => x.Name == name);
    return race is null ? null : RaceResource.From(race);
  }
  public async Task<RaceResourceWithProducts<GoodResource>?> ReadWithProducts(Guid id) {
    var race = _context.Races
      .Include(g => g.Products)
      .FirstOrDefault(g => g.Id == id);

    return race is null ? null : RaceResourceWithProducts<GoodResource>.From(race);
  }
  public async Task<RaceResourceWithProducts<GoodResource>?> ReadWithProducts(string name) {
    var race = _context.Races
      .Include(g => g.Products)
      .FirstOrDefault(g => g.Name == name);

    return race is null ? null : RaceResourceWithProducts<GoodResource>.From(race);
  }
  public async Task<IEnumerable<RaceResource>> ReadAll()
    => _context.Races
      .Select(RaceResource.From);

  public async Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    ReadAllWithProducts()
    => _context.Races
      .Include(r => r.Products)
      .Select(RaceResourceWithProducts<GoodResource>.From);

  public async Task<IEnumerable<RaceResource>>
    FilterBy(string? name, string? decadency, string? needs, string? will)
    => _context.Races
      .Where(r => name == null || r.Name.ToLower().Contains(name.ToLower()))
      .Where(r => decadency == null || r.Decadency == decadency)
      .Where(r => needs == null || r.Needs == needs)
      .Where(r => will == null || r.Will == will)
      .AsEnumerable()
      .Select(RaceResource.From);

  public async Task<IEnumerable<RaceResourceWithProducts<GoodResource>>>
    FilterWithProductsBy(string? name, string? decadency, string? needs, string? will)
    => _context.Races
      .Include(r => r.Products)
      .Where(r => name == null || r.Name.ToLower().Contains(name.ToLower()))
      .Where(r => decadency == null || r.Decadency == decadency)
      .Where(r => needs == null || r.Needs == needs)
      .Where(r => will == null || r.Will == will)
      .AsEnumerable()
      .Select(RaceResourceWithProducts<GoodResource>.From);

  public async Task<bool> Create(RaceModel model) {
    try {
      _context.Races.Add(RaceEntity.From(model));
      await _context.SaveChangesAsync();
      return true;
    } catch {
      return false;
    }
  }
  public async Task<bool> Remove(Guid id) {
    try {
      var race = _context.Races.FirstOrDefault(x => x.Id == id);
      if (race is null) return false;
      _context.Races.Remove(race);
      await _context.SaveChangesAsync();
      return true;
    } catch {
      return false;
    }
  }
  public async Task<bool> Update(Guid id, RaceModel model) {
    try {
      var race = _context.Races.FirstOrDefault(x => x.Id == id);
      if (race is null) return false;
      _context.Races.Update(
        race with {
          Name = model.Name,
          Description = model.Description,
          Decadency = model.Decadency,
          Needs = model.Needs,
          Will = model.Will,
          UpdatedAt = DateTime.Now
        }
      );
      await _context.SaveChangesAsync();
      return true;
    } catch {
      return false;
    }
  }

  public RaceService(DatabaseContext context) => _context = context;
  private readonly DatabaseContext _context;
}
