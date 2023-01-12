using DataModels.Toasts;

namespace Services.Toasts;

public sealed class ToastService : IToastService {
  public List<Toast> Toasts { get; } = new();
  public event Action ToastsStateChanged = null!;

  public async Task AddAsync(string title, string message, ToastType? type = default) {
    var toast = new Toast(title, message, type);
    Toasts.Add(toast);
    ToastsStateChanged();
    await Task.Delay(1500);

    toast.IsEntering = false;
    ToastsStateChanged();
    await Task.Delay(600);

    toast.IsVisible = false;
    ToastsStateChanged();
    ClearAll();
  }

  public async Task RemoveAsync(Toast toast) {
    toast.IsEntering = false;
    ToastsStateChanged();
    await Task.Delay(600);

    toast.IsVisible = false;
    ToastsStateChanged();

    ClearAll();
  }

  public void ClearAll() {
    if (Toasts.Any(toast => toast.IsVisible)) return;

    Toasts.Clear();
    ToastsStateChanged();
  }
}
