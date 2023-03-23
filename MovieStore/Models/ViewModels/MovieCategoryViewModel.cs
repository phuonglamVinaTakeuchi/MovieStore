using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.ViewModels
{
  public class MovieCategoryViewModel
  {
    public int Id { get; set; }
    
    [Display(Name = "Movie Category Name")]
    [Required(ErrorMessage = "Movie Category Name is require")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Movie Category Name must be between 3 and 50 characters")]
    public string? Name { get; set; }
  }
}
