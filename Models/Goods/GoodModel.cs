namespace Models.Goods;

public sealed record GoodModel(string Name, string? Description)
  : IGood {
  public static GoodModel From(IGood good) => new(good.Name, good.Description);
}
