using Imdb.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Imdb.Data;

public class ImdbContext : IdentityDbContext
//public class ImdbContext : DbContext
{
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public ImdbContext(DbContextOptions<ImdbContext> options)
  : base(options)
    { }
}
