namespace MovieStore.Models.Entities
{
  public class Movie : IEntityBase
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double Price { get; set; }
    public string? ImgUrl { get; set; }

    #region Relationships

    public int CinemaId { get; set; }

    //[ForeignKey(nameof(CinemaId))]
    public Cinema? Cinema { get; set; }

    public int ProducerId { get; set; }

    //[ForeignKey(nameof(ProducerId))]
    public Producer? Producer { get; set; }

    public int MovieCategoryId { get; set; }

    //[ForeignKey(nameof(MovieCategoryId))]
    public MovieCategory? MovieCategory { get; set; }

    public ICollection<MoviesActors>? MoviesActors { get; set; }

    #endregion

  }
}
