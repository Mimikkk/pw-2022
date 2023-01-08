using Microsoft.AspNetCore.Components;

namespace pw_2022.Shared.Extensions;

public static class NavigationManagerExtensions {
  public static IEnumerable<string> PathSegments(this NavigationManager manager) =>
    manager.ToBaseRelativePath(manager.Uri).Split('/', StringSplitOptions.RemoveEmptyEntries);
  public static bool IsLastSegment(this NavigationManager manager, string segment) =>
    manager.PathSegments().LastOrDefault() == segment;
}
