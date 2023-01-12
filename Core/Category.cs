namespace Core;

public sealed class Category : SmarterEnum<Category> {
  public static readonly Category Low = new Category(nameof(Low));
  public static readonly Category Medium = new Category(nameof(Medium));
  public static readonly Category High = new Category(nameof(High));

  public Category(string name)
    : base(name.ToLower()) { }
}
