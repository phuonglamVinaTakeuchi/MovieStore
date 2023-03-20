using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MovieStore.Models.Entities.Configuration
{
  public class MoviesActorsConfiguration : IEntityTypeConfiguration<MoviesActors>
  {
    public void Configure(EntityTypeBuilder<MoviesActors> builder)
    {
      builder.HasKey(ma => new
      {
        ma.ActorId,
        ma.MovieId
      });

      builder
        .HasOne(ma => ma.Movie)
        .WithMany(m => m.MoviesActors)
        .HasForeignKey(ma => ma.MovieId);

      builder
        .HasOne(ma => ma.Actor)
        .WithMany(a => a.MoviesActors)
        .HasForeignKey(ma => ma.ActorId);
    }
  }
}
