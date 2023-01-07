namespace pw_2022.Shared.Utils;

public static class Utils {
  public static string Cx(params string?[] names) => string.Join(" ", names.Where(s => s is not null && s.Length > 0));
}
