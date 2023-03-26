using System.ComponentModel.DataAnnotations;
using MovieStore.Models.Entities;

namespace MovieStore.Models.ViewModels;

public class MovieViewModel
{
  public int Id { get; set; }

  [Display(Name = "Name")]
  [Required(ErrorMessage = "Name is require")]
  public string? Name { get; set; }
  public string? Description { get; set; }
  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public double Price { get; set; }

  [Display(Name = "Movie Banner")]
  [Required(ErrorMessage = "Movie Banner is require")]
  public string? ImgUrl { get; set; }
  #region Relationships

  public int CinemaId { get; set; }
  public Cinema? Cinema { get; set; }

  public int ProducerId { get; set; }

  public Producer? Producer { get; set; }

  public int MovieCategoryId { get; set; }

  public MovieCategory? MovieCategory { get; set; }

  //public ICollection<MoviesActors>? MoviesActors { get; set; }

  #endregion
}