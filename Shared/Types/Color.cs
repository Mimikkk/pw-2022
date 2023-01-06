using Ardalis.SmartEnum;

namespace pw_2022.Shared.Types;

public class Color : SmartEnum<Color> {
  public static readonly Color Shade = new("stone", 0);
  public static readonly Color Primary = new("indigo", 1);
  public static readonly Color Secondary = new("emerald", 2);
  public static readonly Color Accent = new("amber", 3);
  public static readonly Color Error = new("rose", 4);
  public static readonly Color Warning = new("yellow", 5);


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
    _ => $"{type}-{this}-{shade}00"
  };
}
