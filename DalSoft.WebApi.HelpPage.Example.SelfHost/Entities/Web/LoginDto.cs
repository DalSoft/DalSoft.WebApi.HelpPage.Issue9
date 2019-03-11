using System.ComponentModel.DataAnnotations;

namespace GDIInterface.Models.Entities.Web
{
    public class LoginDto
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }

        public LoginDto()
        {

        }

        public LoginDto(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

    }
}
