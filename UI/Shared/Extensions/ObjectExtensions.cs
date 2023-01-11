using System.Reflection;

namespace UI.Shared.Extensions;

public static class ObjectExtensions {
  public static T? Access<T>(this object @object, string param) where T : class =>
    @object.GetType().GetProperty(param)?.GetValue(@object) as T;

  public static Action Method(this object @object, string method) {
    var action = @object.GetType().GetMethod(method, BindingFlags.Instance | BindingFlags.NonPublic);
    void Action() => action?.Invoke(@object, null);
    return Action;
  }
}
