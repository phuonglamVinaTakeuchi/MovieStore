using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.Entities
{
  public class Cinema : IEntityBase
  {
    public int Id { get; set; }

    [Display(Name = "Cinema Logo")]
    [Required(ErrorMessage = "Cinema Logo is require")]
    public string? Logo { get; set; }

    [Display(Name = "Cinema Name")]
    [Required(ErrorMessage = "Cinema Name is require")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Cinema Name must be between 3 and 50 characters")]
    public string? Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Movie>? Movies { get; set; }
  }
}
