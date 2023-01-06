using Ardalis.SmartEnum;

namespace pw_2022.Shared.Types;

public class Color : SmartEnum<Color> {
  public static readonly Color Shade = new("stone", 2);
  public static readonly Color Primary = new("indigo", 3);
  public static readonly Color Secondary = new("emerald", 3);
  public static readonly Color Accent = new("amber", 3);
  public static readonly Color Error = new("rose", 3);
  public static readonly Color Warning = new("yellow", 3);


  public Color(string name, int value)
    : base(name, value) { }

  public static implicit operator Color(string name) => FromName(name);

  public class ColorType : SmartEnum<ColorType> {
    public static readonly ColorType Background = new("bg", 0);
    public static readonly ColorType Text = new("text", 1);
    public static readonly ColorType Border = new("border", 2);
    public static readonly ColorType Outline = new("outline", 3);

    public ColorType(string name, int value)
      : base(name, value) { }

    public static implicit operator ColorType(string name) => FromName(name);
  }

  public string this[ColorType type, int shade] => shade switch {
    0 => $"{type}-{this}-50",
    1 => $"{type}-{this}-100",
    2 => $"{type}-{this}-200",
    3 => $"{type}-{this}-300",
    4 => $"{type}-{this}-400",
    5 => $"{type}-{this}-500",
    6 => $"{type}-{this}-600",
    7 => $"{type}-{this}-700",
    8 => $"{type}-{this}-800",
    9 => $"{type}-{this}-900",
  };
}
