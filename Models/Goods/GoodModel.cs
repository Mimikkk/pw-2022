namespace DataModels.Goods;

public sealed record GoodModel(string Name, string? Description)
  : IGood;
