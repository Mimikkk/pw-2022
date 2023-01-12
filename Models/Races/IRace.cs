using Core;

namespace DataModels.Races;

public interface IRace {
  string Name { get; init; }
  string? Description { get; init; }
  Category Needs { get; init; }
  Category Decadency { get; init; }
  Category Will { get; init; }
}
