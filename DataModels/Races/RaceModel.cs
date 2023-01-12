namespace DataModels.Races;

public record RaceModel(string Name, string? Description, string Needs, string Decadency, string Will)
  : IRace;
