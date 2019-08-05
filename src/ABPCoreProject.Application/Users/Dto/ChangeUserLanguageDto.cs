using System.ComponentModel.DataAnnotations;

namespace ABPCoreProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}