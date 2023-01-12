using Bogus;

namespace Mocks.Services;

public abstract class MockService {
  private static Faker Faker { get; } = new();
  protected static async Task Delay() => await Task.Delay(Faker.Random.Int(100, 200));
}
