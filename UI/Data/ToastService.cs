using UI.Shared.Types;

namespace UI.Data;

public class ToastService {
  public List<Toast> Toasts { get; } = new();

  public event Action ToastsStateChanged = null!;

  public async Task AddAsync(string message, ToastType? type = default) {
    var toast = new Toast(message, type);
    Toasts.Add(toast);
    ToastsStateChanged();

    await Task.Delay(1500);
    toast.IsEntering = false;
    ToastsStateChanged();

    await Task.Delay(600);
    toast.IsVisible = false;
    ToastsStateChanged();
    ClearAllToasts();
  }

  public async Task RemoveAsync(Toast toast) {
    toast.IsEntering = false;
    ToastsStateChanged();

    await Task.Delay(600);

    toast.IsVisible = false;
    ToastsStateChanged();

    ClearAllToasts();
  }

  public void ClearAllToasts() {
    if (Toasts.Any(toast => toast.IsVisible)) return;

    Toasts.Clear();
    ToastsStateChanged();
  }
}
