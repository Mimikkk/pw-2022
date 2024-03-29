﻿using Microsoft.AspNetCore.Components;
using UI.Shared.Extensions;

namespace UI.Shared.Utils;

public static partial class Utils {
  public static (Func<T>, Action<T>) CreateSignal<T>(ComponentBase element, T initialValue = default!) {
    var _value = initialValue;

    T Getter() => _value;
    void Setter(T value) {
      _value = value;
      element.Method("StateHasChanged")();
    }
    return (Getter, Setter);
  }

  public static (Func<bool>, Action<bool?>) CreateToggle(ComponentBase element, bool? initialValue = null) {
    var (getter, setter) = CreateSignal(element, initialValue ?? false);
    void Toggle(bool? value = null) => setter(value ?? !getter());
    return (getter, Toggle);
  }
}
