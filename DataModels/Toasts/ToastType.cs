using Core;

namespace DataModels.Toasts;

public class ToastType : SmarterEnum<ToastType> {
  public static readonly ToastType Success = new(nameof(Success));
  public static readonly ToastType Info = new(nameof(Info));
  public static readonly ToastType Warning = new(nameof(Warning));
  public static readonly ToastType Error = new(nameof(Error));

  private ToastType(string name)
    : base(name.ToLower()) { }

  public static implicit operator ToastType(string type) => FromName(type);
}
