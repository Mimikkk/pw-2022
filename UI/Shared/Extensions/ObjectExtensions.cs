using Microsoft.AspNetCore.Components;

namespace UI.Shared.Extensions;

public static class ObjectExtensions {
  public static T? Access<T>(this object @object, string param) where T : class =>
    @object.GetType().GetProperty(param)?.GetValue(@object) as T;
}
