using Microsoft.EntityFrameworkCore;
using MovieStore.Models.Entities;
using MovieStore.Models.Entities.Configuration;

namespace MovieStore.Data
{
  public class AppDbContext : DbContext
  {
    public DbSet<Actor>? Actors { get; set; }
    public DbSet<Movie>? Movies { get; set; }
    public DbSet<MoviesActors>? MoviesActors { get; set; }
    public DbSet<Cinema>? Cinemas { get; set; }
    public DbSet<Producer>? Producers { get; set; }
    public DbSet<MovieCategory>? MovieCategories { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
      
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new MoviesActorsConfiguration());
      base.OnModelCreating(modelBuilder);
    }
  }
}
