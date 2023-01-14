namespace UI.Shared.Utils;

public static partial class Utils {
  public static string Cx(params string?[] names) => string.Join(" ", names.Where(s => s is not null && s.Length > 0));

  public static void Log(object? text) => Console.WriteLine($"{text ?? "null"}");
}
