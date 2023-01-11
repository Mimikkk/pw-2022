using UI.Shared.Types;

namespace UI.Data;

public class Toast {
  public ToastType Type { get; } = ToastType.Info;
  public string Message { get; }
  public bool IsVisible { get; set; } = true;
  public bool IsEntering { get; set; } = true;

  public Toast(string message, ToastType? type) {
    if (type is not null) Type = type;
    Message = message;
  }
}
