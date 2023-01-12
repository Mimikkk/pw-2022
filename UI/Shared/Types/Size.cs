using Ardalis.SmartEnum;

namespace UI.Shared.Types;

public sealed class Size : SmartEnum<Size> {
  public static readonly Size Xs = new(nameof(Xs), 1);
  public static readonly Size Sm = new(nameof(Sm), 2);
  public static readonly Size Md = new(nameof(Md), 3);
  public static readonly Size Lg = new(nameof(Lg), 4);
  public static readonly Size Xl = new(nameof(Xl), 6);


  public Size(string name, int value)
    : base(name, value) { }

  public string Height => $"h-{Value * 3}";

  public string Width => $"w-{Value * 3}";

  public string FontSize => Name switch {
    "MD" => "text-base",
    _    => $"text-{Name.ToLower()}"
  };

  public static implicit operator Size(string name) => FromName(name);
}
