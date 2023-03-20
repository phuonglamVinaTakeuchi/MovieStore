using MovieStore.Models.Entities;

namespace MovieStore.Data.SeedData
{
  public static class CollectionExtension
  {
    public static readonly string[] OrdinalNumbers = new string[] { "first", "second", "third", "fourth", "fifth" };

    public static IEnumerable<Cinema> CreateCinemas()
    {
      for (var i = 0; i < 5; i++)
      {
        yield return new Cinema()
        {
          Name = $"Cinema {i + 1}",
          Logo = $"http://dotnethow.net/images/cinemas/cinema-{i + 1}.jpeg",
          Description = $"This is the {OrdinalNumbers[i]} cinema"
        };
      }
    }

    public static IEnumerable<Actor> CreateActors()
    {
      for (var i = 0; i < 5; i++)
      {
        yield return new Actor()
        {
          FullName = $"Actor {i}",
          Bio = $"This is the Bio of the  {OrdinalNumbers[i]} actor",
          ProfilePictureUrl = $"http://dotnethow.net/images/actors/actor-{i + 1}.jpeg"
        };
      }
    }

    public static IEnumerable<Producer> CreateProducers()
    {
      for (var i = 0; i < 5; i++)
      {
        yield return new Producer()
        {
          FullName = $"Producer {i}",
          Bio = $"This is the Bio of the  {OrdinalNumbers[i]} producer",
          ProfilePictureUrl = $"http://dotnethow.net/images/producers/producer-{i + 1}.jpeg"
        };
      }
    }

    public static List<MovieCategory> CreateMovieCategories()
    {
      return new List<MovieCategory>()
      {
        new MovieCategory()
        {
          Name = "Action"
        },
        new MovieCategory()
        {
          Name = "Comedy"
        },
        new MovieCategory()
        {
          Name = "Documentary"
        },
        new MovieCategory()
        {
          Name = "Drama"
        },
        new MovieCategory()
        {
          Name = "Horror"
        },
        new MovieCategory()
        {
          Name = "Romance"
        },
        new MovieCategory()
        {
          Name = "Thriller"
        },
        new MovieCategory()
        {
          Name = "Cartoon"
        }
      };
    }

    public static List<Movie> CreateMovies()
    {
      return new List<Movie>()
      {
        new Movie()
        {
          Name = "Life",
          Description = "This is the Life movie description",
          Price = 39.50,
          ImgUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
          StartDate = DateTime.Now.AddDays(-10),
          EndDate = DateTime.Now.AddDays(10),
          CinemaId = 3,
          ProducerId = 3,
          MovieCategoryId = 3
        },
        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImgUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategoryId = 1
                        },
        new Movie()
        {
          Name = "Ghost",
          Description = "This is the Ghost movie description",
          Price = 39.50,
          ImgUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
          StartDate = DateTime.Now,
          EndDate = DateTime.Now.AddDays(7),
          CinemaId = 4,
          ProducerId = 4,
          MovieCategoryId = 5
        },
        new Movie()
        {
          Name = "Race",
          Description = "This is the Race movie description",
          Price = 39.50,
          ImgUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
          StartDate = DateTime.Now.AddDays(-10),
          EndDate = DateTime.Now.AddDays(-5),
          CinemaId = 1,
          ProducerId = 2,
          MovieCategoryId = 3
        },
        new Movie()
        {
          Name = "Scoob",
          Description = "This is the Scoob movie description",
          Price = 39.50,
          ImgUrl = "http://dotnethow.net/images/movies/movie-7.jpeg",
          StartDate = DateTime.Now.AddDays(-10),
          EndDate = DateTime.Now.AddDays(-2),
          CinemaId = 1,
          ProducerId = 3,
          MovieCategoryId = 8
        },
        new Movie()
        {
          Name = "Cold Soles",
          Description = "This is the Cold Soles movie description",
          Price = 39.50,
          ImgUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
          StartDate = DateTime.Now.AddDays(3),
          EndDate = DateTime.Now.AddDays(20),
          CinemaId = 1,
          ProducerId = 5,
          MovieCategoryId = 4
        }
      };
    }

    public static List<MoviesActors> CreateMoviesActors()
    {
      return new List<MoviesActors>()
      {
        new MoviesActors()
        {
          ActorId = 1,
          MovieId = 1
        },
        new MoviesActors()
        {
          ActorId = 3,
          MovieId = 1
        },
        new MoviesActors()
        {
          ActorId = 1,
          MovieId = 2
        },
        new MoviesActors()
        {
          ActorId = 4,
          MovieId = 2
        },
        new MoviesActors()
        {
          ActorId = 1,
          MovieId = 3
        },
        new MoviesActors()
        {
          ActorId = 2,
          MovieId = 3
        },
        new MoviesActors()
        {
          ActorId = 5,
          MovieId = 3
        },
        new MoviesActors()
        {
          ActorId = 2,
          MovieId = 4
        },
        new MoviesActors()
        {
          ActorId = 3,
          MovieId = 4
        },
        new MoviesActors()
        {
          ActorId = 4,
          MovieId = 4
        },
        new MoviesActors()
        {
          ActorId = 2,
          MovieId = 5
        },
        new MoviesActors()
        {
          ActorId = 3,
          MovieId = 5
        },
        new MoviesActors()
        {
          ActorId = 4,
          MovieId = 5
        },
        new MoviesActors()
        {
          ActorId = 5,
          MovieId = 5
        },
        new MoviesActors()
        {
          ActorId = 3,
          MovieId = 6
        },
        new MoviesActors()
        {
          ActorId = 4,
          MovieId = 6
        },
        new MoviesActors()
        {
          ActorId = 5,
          MovieId = 6
        },
      };
    }
  }
}
