using Core;

namespace Models.Races;

public sealed record RaceModel(
  string Name, string? Description, Category Needs, Category Decadency, Category Will
) : IRace {
  public static RaceModel From(IRace race)
    => new(race.Name, race.Description, race.Needs, race.Decadency, race.Will);
}
