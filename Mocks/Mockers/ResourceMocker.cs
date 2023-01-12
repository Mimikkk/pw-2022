using Bogus;
using DataModels;

namespace Mocks.Mockers;

internal static class ResourceMocker {
  public static Faker<T> ApplyResourceRules<T>(this Faker<T> faker)
    where T : class, IResource
    => faker
      .RuleFor(r => r.Id, f => f.Random.Guid())
      .RuleFor(g => g.CreatedAt, f => f.Date.Past())
      .RuleFor(g => g.UpdatedAt, f => f.Random.Bool() ? f.Date.Past() : null);
}
