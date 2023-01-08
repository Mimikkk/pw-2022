using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using pw_2022.Shared.Components.Icons.Paths;

namespace pw_2022.Shared.Components.Icons;

public class IconType : SmartEnum<IconType> {
  public static readonly IconType Bin = new(nameof(Bin), 0, typeof(BinPath));
  public static readonly IconType Burger = new(nameof(Burger), 1, typeof(BurgerPath));
  public static readonly IconType DownChevron = new(nameof(DownChevron), 2, typeof(DownChevronPath));
  public static readonly IconType ExclamationCircle = new(nameof(ExclamationCircle), 3, typeof(ExclamationCirclePath));
  public static readonly IconType ExclamationTriangle = new(nameof(ExclamationTriangle), 4, typeof(ExclamationTrianglePath));
  public static readonly IconType Github = new(nameof(Github), 5, typeof(GithubPath));
  public static readonly IconType Home = new(nameof(Home), 6, typeof(HomePath));
  public static readonly IconType LeftChevronDouble = new(nameof(LeftChevronDouble), 7, typeof(LeftChevronDoublePath));
  public static readonly IconType LeftChevron = new(nameof(LeftChevron), 8, typeof(LeftChevronPath));
  public static readonly IconType Magnifier = new(nameof(Magnifier), 9, typeof(MagnifierPath));
  public static readonly IconType Minus = new(nameof(Minus), 10, typeof(MinusPath));
  public static readonly IconType Moon = new(nameof(Moon), 11, typeof(MoonPath));
  public static readonly IconType Pen = new(nameof(Pen), 12, typeof(PenPath));
  public static readonly IconType Person = new(nameof(Person), 13, typeof(PersonPath));
  public static readonly IconType Plus = new(nameof(Plus), 14, typeof(PlusPath));
  public static readonly IconType RightChevronDouble = new(nameof(RightChevronDouble), 15, typeof(RightChevronDoublePath));
  public static readonly IconType RightChevron = new(nameof(RightChevron), 16, typeof(RightChevronPath));
  public static readonly IconType Stack = new(nameof(Stack), 17, typeof(StackPath));
  public static readonly IconType Sun = new(nameof(Sun), 18, typeof(SunPath));
  public static readonly IconType X = new(nameof(X), 19, typeof(XPath));

  public IconType(string name, int value, Type component)
    : base(name, value)
    => _component = component;

  public RenderFragment Component => builder => {
    builder.OpenComponent(0, _component);
    builder.CloseComponent();
  };

  private readonly Type _component;
}
