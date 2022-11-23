using Microsoft.EntityFrameworkCore;

namespace AspNetCore {
  public class AppContext : DbContext
  {
    public AppContext(DbContextOptions<AppContext> options) : base(options)
    { }

    public DbSet<ProjectTeam> ProjectTeams { get; set; } = null!;
  }
}