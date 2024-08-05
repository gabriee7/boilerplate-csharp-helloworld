using System.ComponentModel.DataAnnotations;

namespace MyTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}