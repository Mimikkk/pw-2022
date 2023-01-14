using System.ComponentModel.DataAnnotations;

namespace DataModels;

public interface IResource {
  [Key]
  Guid Id { get; init; }
  DateTime CreatedAt { get; init; }
  DateTime? UpdatedAt { get; init; }
}
