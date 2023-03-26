using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.Entities
{
  public class Producer : IEntityBase
  {
    public int Id { get; set; }


    [Required(ErrorMessage = "Profile picture is require")]
    [Display(Name = "Profile Picture")]
    public string? ProfilePictureUrl { get; set; }

    [Required(ErrorMessage = "Full Name is require")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
    [Display(Name = "Full Name")]
    public string? FullName { get; set; }

    [Display(Name = "Biography")]
    public string? Bio { get; set; }
    public ICollection<Movie>? Movies { get; set; }
  }
}
