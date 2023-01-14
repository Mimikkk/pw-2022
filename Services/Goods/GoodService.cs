using Database;
using Microsoft.EntityFrameworkCore;
using Models.Goods;
using Models.Races;

namespace Services.Goods;

public sealed class GoodService : IGoodService {
  public async Task<GoodResource?> Read(Guid id) {
    var good = _context.Goods.FirstOrDefault(x => x.Id == id);
    return good is null ? null : GoodResource.From(good);
  }
  public async Task<GoodResource?> Read(string name) {
    var good = _context.Goods.FirstOrDefault(x => x.Name == name);
    return good is null ? null : GoodResource.From(good);
  }
  public async Task<GoodResourceWithProducer<RaceResource>?> ReadWithProducer(Guid id) {
    var good = _context.Goods
      .Include(g => g.Producer)
      .FirstOrDefault(g => g.Id == id);

    return good is null ? null : GoodResourceWithProducer<RaceResource>.From(good);
  }

  public async Task<GoodResourceWithProducer<RaceResource>?> ReadWithProducer(string name) {
    var good = _context.Goods
      .Include(g => g.Producer)
      .FirstOrDefault(g => g.Name == name);

    return good is null ? null : GoodResourceWithProducer<RaceResource>.From(good);
  }
  public async Task<IEnumerable<GoodResource>> ReadAll()
    => _context.Goods
    .Select(GoodResource.From);

  public async Task<IEnumerable<GoodResource>> FilterBy(string? name)
    => _context.Goods
      .Select(GoodResource.From)
      .Where(g => name is null || g.Name.ToLower().Contains(name.ToLower()))
      .OrderByDescending(x => x.UpdatedAt ?? x.CreatedAt);

  public async Task<bool> Create(Guid raceId, GoodModel model) {
    try {
      _context.Goods.Add(GoodEntity.From(raceId, model));
      return true;
    } catch {
      return false;
    }
  }
  public async Task<bool> Remove(Guid id) {
    try {
      var good = _context.Goods.FirstOrDefault(x => x.Id == id);
      if (good is null) return false;
      _context.Goods.Remove(good);
      return true;
    } catch {
      return false;
    }
  }
  public async Task<bool> Update(Guid id, GoodModel model) {
    try {
      var good = _context.Goods.FirstOrDefault(x => x.Id == id);
      if (good is null) return false;
      _context.Goods.Update(
        good with {
          Name = model.Name,
          Description = model.Description,
          UpdatedAt = DateTime.Now
        }
      );
      return true;
    } catch {
      return false;
    }
  }

  public GoodService(DatabaseContext context) => _context = context;
  private readonly DatabaseContext _context;
}
