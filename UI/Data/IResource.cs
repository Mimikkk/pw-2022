namespace UI.Data;

public interface IResource {
  Guid Id { get; init; }
  DateTime CreatedAt { get; init; }
  DateTime? UpdatedAt { get; init; }
}
