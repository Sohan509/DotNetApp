using System.ComponentModel.DataAnnotations;

namespace DotNetApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string username { get; set; }
        
        [Required]
        [StringLength(12,MinimumLength=4,ErrorMessage="Password should have length of 4 to 8")]
        public string password { get; set; }
    }
}