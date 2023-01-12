using DataModels.Toasts;

namespace UI.Data;

public interface IToastService {
  public List<Toast> Toasts { get; }
  public event Action ToastsStateChanged;

  public Task AddAsync(string title, string message, ToastType? type = default);

  public Task RemoveAsync(Toast toast);

  public void ClearAll();
}
