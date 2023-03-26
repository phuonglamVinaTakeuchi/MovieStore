using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models.ViewModels
{
  public class ProducerViewModel
  {
    public int Id { get; set; }

    [Display(Name = "Profile Picture")]
    [Required(ErrorMessage = "Profile picture is require")]
    public string? ProfilePictureUrl { get; set; }


    [Display(Name = "Full Name")]
    [Required(ErrorMessage = "Full Name is require")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 characters")]
    public string? FullName { get; set; }
    [Display(Name = "Biography")]
    public string? Bio { get; set; }
  }
}
