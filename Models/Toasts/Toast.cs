namespace Models.Toasts;

public sealed class Toast : IToast {
  public ToastType Type { get; } = ToastType.Info;
  public string Message { get; }
  public string Title { get; }
  public bool IsVisible { get; set; } = true;
  public bool IsEntering { get; set; } = true;

  public Toast(string title, string message, ToastType? type) {
    if (type is not null) Type = type;
    Title = title;
    Message = message;
  }
}
