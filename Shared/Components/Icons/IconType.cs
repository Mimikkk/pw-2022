using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using pw_2022.Shared.Components.Icons.Paths;

namespace pw_2022.Shared.Components.Icons;

public class IconType : SmartEnum<IconType> {
  public static readonly IconType Bin = new("Bin", 0, typeof(BinPath));
  public static readonly IconType Burger = new("Burger", 1, typeof(BurgerPath));
  public static readonly IconType ExclamationCircle = new("ExclamationCircle", 2, typeof(ExclamationCirclePath));
  public static readonly IconType ExclamationTriangle = new("ExclamationTriangle", 3, typeof(ExclamationTrianglePath));
  public static readonly IconType Github = new("Github", 3, typeof(GithubPath));
  public static readonly IconType Home = new("Home", 4, typeof(HomePath));
  public static readonly IconType LeftChevronDouble = new("LeftChevronDouble", 5, typeof(LeftChevronDoublePath));
  public static readonly IconType LeftChevron = new("LeftChevron", 6, typeof(LeftChevronPath));
  public static readonly IconType Magnifier = new("Magnifier", 7, typeof(MagnifierPath));
  public static readonly IconType Minus = new("Minus", 8, typeof(MinusPath));
  public static readonly IconType Moon = new("Moon", 9, typeof(MoonPath));
  public static readonly IconType Pen = new("Pen", 10, typeof(PenPath));
  public static readonly IconType Person = new("Person", 11, typeof(PersonPath));
  public static readonly IconType Plus = new("Plus", 12, typeof(PlusPath));
  public static readonly IconType RightChevronDouble = new("RightChevronDouble", 13, typeof(RightChevronDoublePath));
  public static readonly IconType RightChevron = new("RightChevron", 14, typeof(RightChevronPath));
  public static readonly IconType Stack = new("Stack", 15, typeof(StackPath));
  public static readonly IconType Sun = new("Sun", 16, typeof(SunPath));
  public static readonly IconType X = new("X", 17, typeof(XPath));

  public IconType(string name, int value, Type component)
    : base(name, value)
    => _component = component;

  public RenderFragment Component => builder => {
    builder.OpenComponent(0, _component);
    builder.CloseComponent();
  };

  private readonly Type _component;
}
