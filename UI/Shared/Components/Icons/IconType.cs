using Ardalis.SmartEnum;
using Microsoft.AspNetCore.Components;
using UI.Shared.Components.Icons.Paths;

namespace UI.Shared.Components.Icons;

public class IconType : SmartEnum<IconType> {
  public static readonly IconType Bin = new(nameof(Bin), typeof(BinPath));
  public static readonly IconType Burger = new(nameof(Burger), typeof(BurgerPath));
  public static readonly IconType DownChevron = new(nameof(DownChevron), typeof(DownChevronPath));
  public static readonly IconType ExclamationCircle = new(nameof(ExclamationCircle), typeof(ExclamationCirclePath));
  public static readonly IconType ExclamationTriangle = new(nameof(ExclamationTriangle), typeof(ExclamationTrianglePath));
  public static readonly IconType Filter = new(nameof(Filter), typeof(FilterPath));
  public static readonly IconType Github = new(nameof(Github), typeof(GithubPath));
  public static readonly IconType Home = new(nameof(Home), typeof(HomePath));
  public static readonly IconType LeftChevronDouble = new(nameof(LeftChevronDouble), typeof(LeftChevronDoublePath));
  public static readonly IconType LeftChevron = new(nameof(LeftChevron), typeof(LeftChevronPath));
  public static readonly IconType Magnifier = new(nameof(Magnifier), typeof(MagnifierPath));
  public static readonly IconType Minus = new(nameof(Minus), typeof(MinusPath));
  public static readonly IconType Moon = new(nameof(Moon), typeof(MoonPath));
  public static readonly IconType Pen = new(nameof(Pen), typeof(PenPath));
  public static readonly IconType Person = new(nameof(Person), typeof(PersonPath));
  public static readonly IconType Plus = new(nameof(Plus), typeof(PlusPath));
  public static readonly IconType RightChevronDouble = new(nameof(RightChevronDouble), typeof(RightChevronDoublePath));
  public static readonly IconType RightChevron = new(nameof(RightChevron), typeof(RightChevronPath));
  public static readonly IconType Stack = new(nameof(Stack), typeof(StackPath));
  public static readonly IconType Sun = new(nameof(Sun), typeof(SunPath));
  public static readonly IconType X = new(nameof(X), typeof(XPath));

  public IconType(string name, Type component)
    : base(name, ++_count) => _component = component;

  public RenderFragment Component => builder => {
    builder.OpenComponent(0, _component);
    builder.CloseComponent();
  };

  public static implicit operator IconType(string name) => FromName(name);
  private readonly Type _component;
  private static int _count;
}
