using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.ViewModels
{
  public class CinemaViewModel
  {
    public int Id { get; set; }
    public string? Logo { get; set; }

    [Display(Name = "Cinema Name")]
    [Required(ErrorMessage = "Cinema Name is require")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema Name must be between 3 and 50 characters")]
    public string? Name { get; set; }
    public string? Description { get; set; }
  }
}
