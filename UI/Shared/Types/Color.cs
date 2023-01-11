using Ardalis.SmartEnum;

namespace UI.Shared.Types;

public class Color : SmarterEnum<Color> {
  public static readonly Color Shade = new("stone");
  public static readonly Color Primary = new("indigo");
  public static readonly Color Secondary = new("violet");
  public static readonly Color Accent = new("amber");
  public static readonly Color Error = new("rose");
  public static readonly Color Warning = new("yellow");
  public static readonly Color Black = new("black");
  public static readonly Color White = new("white");


  public Color(string name)
    : base(name) { }

  public static implicit operator Color(string name) => FromName(name);

  public class ColorType : SmarterEnum<ColorType> {
    public static readonly ColorType Background = new("bg");
    public static readonly ColorType Text = new(nameof(Text));
    public static readonly ColorType Border = new(nameof(Border));
    public static readonly ColorType Outline = new(nameof(Outline));
    public static readonly ColorType Fill = new(nameof(Fill));
    public static readonly ColorType Shadow = new(nameof(Shadow));
    public static readonly ColorType From = new(nameof(From));
    public static readonly ColorType Via = new(nameof(Via));
    public static readonly ColorType To = new(nameof(To));

    public ColorType(string name)
      : base(name.ToLower()) { }

    public static implicit operator ColorType(string name) => FromName(name);
  }

  public string this[ColorType type, int shade] => shade switch {
    0    => $"{type}-{this}-50",
    <= 9 => $"{type}-{this}-{shade}00",
    _    => throw new ArgumentOutOfRangeException(nameof(shade), shade, "Shade must be between 0 and 9")
  };
  public string this[ColorType type] => Name switch {
    "black" => $"{type}-{this}",
    "white" => $"{type}-{this}",
    _       => $"{type}-{this}-500"
  };
}
