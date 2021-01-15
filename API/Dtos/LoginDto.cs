using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class LoginDto
    {
        
        [Required]
        public string Email{get; set;}
        [Required]
        [DataType(DataType.Password)]
        public string Password{get; set;}
    }
}