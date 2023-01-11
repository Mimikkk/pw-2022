using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using UI.Shared.Components.Typography;

namespace UI.Shared.Utils;

public static partial class Utils {
  public static string Cx(params string?[] names) => string.Join(" ", names.Where(s => s is not null && s.Length > 0));

  public static RenderFragment Render(object value) => builder => {
    builder.OpenComponent<Typography>(0);
    builder.AddContent(1, value.ToString());
    builder.CloseComponent();
  };

  public static void Log(this IJSRuntime js, string text) => js.InvokeVoidAsync("console.log", text);
  public static void Log(object? text) => Console.WriteLine(text?.ToString() ?? "null");
}
