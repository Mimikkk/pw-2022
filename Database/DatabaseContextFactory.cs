using Microsoft.EntityFrameworkCore.Design;

namespace Database;

using Microsoft.EntityFrameworkCore;

public sealed class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext> {
  public DatabaseContext CreateDbContext(string[] args) =>
    new DatabaseContext(new DbContextOptionsBuilder<DatabaseContext>()
      .UseSqlite("Filename=./Database/Database.db")
      .Options
    );

  public DatabaseContext Create(string[] args) => CreateDbContext(args);
}
