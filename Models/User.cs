using System.ComponentModel.DataAnnotations;
 
namespace FormSubmission.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MinLength(4)]
        public string FirstName {get; set;}
        
        [Required]
        [MinLength(4)]
        public string LastName {get; set;}
        
        [Required(ErrorMessage = "The Age field is required")]
        [Range(1,int.MaxValue, ErrorMessage = "The Age has to be a positive value!")]
        public int? Age {get; set;}
        
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        
        [Required]
        [MinLength(8)]
        public string Password {get; set;}

    }
}