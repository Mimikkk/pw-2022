namespace DataModels.Goods;

public record GoodModel(string Name, string? Description)
  : IGood;
