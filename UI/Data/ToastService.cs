namespace UI.Data;

public class ToastService {
  public List<Toast> Toasts { get; set; }

  public event Action? ToastsStateChanged;

  public ToastService() => Toasts = new List<Toast>();

  public async Task AddToastAsync(string message, string type = "success") {
    var toast = new Toast(type, message);
    Toasts.Add(toast);
    NotifyToastsStateHasChanged();

    await Task.Delay(1500);
    toast.EnterAnimation = false;
    toast.ExitAnimation = true;
    NotifyToastsStateHasChanged();

    await Task.Delay(600);
    toast.Visible = false;
    NotifyToastsStateHasChanged();
    ClearAllToasts();
  }

  public async Task RemoveToastAsync(Toast toast) {
    toast.EnterAnimation = false;
    toast.ExitAnimation = true;
    NotifyToastsStateHasChanged();

    await Task.Delay(600);

    toast.Visible = false;
    NotifyToastsStateHasChanged();

    ClearAllToasts();
  }

  public void ClearAllToasts() {
    if (Toasts.Any(toast => toast.Visible)) return;

    Toasts.Clear();
    NotifyToastsStateHasChanged();
  }

  private void NotifyToastsStateHasChanged() => ToastsStateChanged?.Invoke();
}
