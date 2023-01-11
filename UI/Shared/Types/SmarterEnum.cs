using Ardalis.SmartEnum;

namespace UI.Shared.Types;

public abstract class SmarterEnum<TEnum> : SmartEnum<TEnum> where TEnum : SmartEnum<TEnum, int> {
  protected SmarterEnum(string name)
    : base(name, _count++) { }

  private static int _count;
}
