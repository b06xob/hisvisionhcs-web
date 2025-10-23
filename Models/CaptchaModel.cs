using System.ComponentModel.DataAnnotations;

namespace HisVisionHCS.Web.Models
{
    public class CaptchaModel
    {
        [Required]
        [Display(Name = "Security Question")]
        public string Question { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Answer")]
        public string Answer { get; set; } = string.Empty;

        public int ExpectedAnswer { get; set; }
    }

    public class CaptchaQuestion
    {
        public string Question { get; set; } = string.Empty;
        public int Answer { get; set; }
    }
}
