﻿using Ardalis.SmartEnum;

namespace pw_2022.Shared.Types;

public class Color : SmartEnum<Color> {
  public static readonly Color Shade = new("stone");
  public static readonly Color Primary = new("indigo");
  public static readonly Color Secondary = new("violet");
  public static readonly Color Accent = new("amber");
  public static readonly Color Error = new("rose");
  public static readonly Color Warning = new("yellow");
  public static readonly Color Black = new("black");
  public static readonly Color White = new("white");


  public Color(string name)
    : base(name, ++_count) { }

  public static implicit operator Color(string name) => FromName(name);

  public class ColorType : SmartEnum<ColorType> {
    public static readonly ColorType Background = new("bg");
    public static readonly ColorType Text = new(nameof(Text));
    public static readonly ColorType Border = new(nameof(Border));
    public static readonly ColorType Outline = new(nameof(Outline));
    public static readonly ColorType Fill = new(nameof(Fill));
    public static readonly ColorType Shadow = new(nameof(Shadow));

    public ColorType(string name)
      : base(name.ToLower(), ++_count) { }

    public static implicit operator ColorType(string name) => FromName(name);
    private static int _count;
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
  private static int _count;
}
