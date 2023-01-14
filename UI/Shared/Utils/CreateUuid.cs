namespace UI.Shared.Utils;

public static partial class Utils {
  public static string CreateStr(int Length = 8) => $"{Guid.NewGuid():n}"[..Length];
}
