using System.ComponentModel.DataAnnotations;

namespace HisVisionHCS.Web.Models
{
    public class CareerApplication
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Address")]
        public string? Address { get; set; }

        [Required]
        [Display(Name = "Position of Interest")]
        public string Position { get; set; } = string.Empty;

        [Display(Name = "Years of Experience")]
        public string? Experience { get; set; }

        [Display(Name = "Availability")]
        public string? Availability { get; set; }

        [Display(Name = "License/Certification Number")]
        public string? License { get; set; }

        [Display(Name = "License/Certification Expiry Date")]
        public DateTime? LicenseExpiry { get; set; }

        [Display(Name = "Additional Skills or Qualifications")]
        public string? AdditionalSkills { get; set; }

        [Display(Name = "What motivates you to work in home health care?")]
        public string? Motivation { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "New";
    }
}
