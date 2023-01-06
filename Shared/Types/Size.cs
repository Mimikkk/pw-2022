using Ardalis.SmartEnum;

namespace pw_2022.Shared.Types;

public class Size : SmartEnum<Size> {
  public static readonly Size Xs = new Size("XS", 1);
  public static readonly Size Sm = new Size("SM", 2);
  public static readonly Size Md = new Size("MD", 3);
  public static readonly Size Lg = new Size("LG", 4);
  public static readonly Size Xl = new Size("XL", 5);


  public Size(string name, int value)
    : base(name, value) { }

  public string Height => Name switch {
    "XS" => "w-2",
    "SM" => "w-4",
    "MD" => "w-6",
    "LG" => "w-8",
    "XL" => "w-10",
  };

  public string Width => Name switch {
    "XS" => "h-2",
    "SM" => "h-4",
    "MD" => "h-6",
    "LG" => "h-8",
    "XL" => "h-10",
  };

  public string FontSize => Name switch {
    "XS" => "text-xs",
    "SM" => "text-sm",
    "MD" => "text-base",
    "LG" => "text-lg",
    "XL" => "text-xl",
  };
}
