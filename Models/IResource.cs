using System.ComponentModel.DataAnnotations;

namespace Models;

public interface IResource {
  [Key]
  Guid Id { get; init; }
  DateTime CreatedAt { get; init; }
  DateTime? UpdatedAt { get; init; }
}
