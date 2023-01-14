using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models.Races;

namespace Models.Goods;

public record GoodEntity(
  [property: ForeignKey(nameof(RaceEntity))]
  Guid ProducerId,
  [property: Key] Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
  string Name, string? Description,
  RaceEntity Producer
) : IGood, IResource {
  public static GoodEntity From(GoodResource good)
    => new(good.ProducerId, good.Id, good.CreatedAt, good.UpdatedAt,
      good.Name, good.Description,
      null!);

  public static GoodEntity From(Guid producerId, GoodModel good)
    => new(producerId, Guid.NewGuid(), DateTime.Now, null,
      good.Name, good.Description,
      null!);

  /// <summary>
  /// EF constructor
  /// </summary>
  private GoodEntity(
    Guid ProducerId, Guid Id, DateTime CreatedAt, DateTime? UpdatedAt,
    string Name, string? Description
  )
    : this(ProducerId, Id, CreatedAt, UpdatedAt, Name, Description, null!) { }
}
