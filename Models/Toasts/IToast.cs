namespace Models.Toasts;

public interface IToast {
  public ToastType Type { get; }
  public string Message { get; }
  public string Title { get; }
  public bool IsVisible { get; set; }
  public bool IsEntering { get; set; }
}
