namespace Interfaces;

public interface IRace {
  string Name { get; init; }
  string? Description { get; init; }
  string Needs { get; init; }
  string Decadency { get; init; }
  string Will { get; init; }
}
