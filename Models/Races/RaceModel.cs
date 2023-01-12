using Core;

namespace DataModels.Races;

public sealed record RaceModel(
  string Name, string? Description, Category Needs, Category Decadency, Category Will
) : IRace;
