using Ardalis.SmartEnum;

namespace pw_2022.Shared.Types;

public class Size : SmartEnum<Size> {
  public static readonly Size Xs = new("XS", 1);
  public static readonly Size Sm = new("SM", 2);
  public static readonly Size Md = new("MD", 3);
  public static readonly Size Lg = new("LG", 4);
  public static readonly Size Xl = new("XL", 6);


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
