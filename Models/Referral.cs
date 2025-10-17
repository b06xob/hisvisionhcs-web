using System.ComponentModel.DataAnnotations;

namespace HisVisionHCS.Web.Models
{
    public class Referral
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Client First Name")]
        public string ClientFirstName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Client Last Name")]
        public string ClientLastName { get; set; } = string.Empty;

        [Display(Name = "Client Phone")]
        public string? ClientPhone { get; set; }

        [EmailAddress]
        [Display(Name = "Client Email")]
        public string? ClientEmail { get; set; }

        [Display(Name = "Client Address")]
        public string? ClientAddress { get; set; }

        [Required]
        [Display(Name = "Referrer Name")]
        public string ReferrerName { get; set; } = string.Empty;

        [Display(Name = "Referrer Title")]
        public string? ReferrerTitle { get; set; }

        [Required]
        [Display(Name = "Referrer Phone")]
        public string ReferrerPhone { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "Referrer Email")]
        public string ReferrerEmail { get; set; } = string.Empty;

        [Display(Name = "Waiver Type")]
        public string? WaiverType { get; set; }

        [Display(Name = "Service Needs")]
        public string? ServiceNeeds { get; set; }

        [Display(Name = "Additional Information")]
        public string? AdditionalInfo { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "New";
    }
}
