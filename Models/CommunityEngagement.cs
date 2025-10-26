using System;
using System.ComponentModel.DataAnnotations;

namespace HisVisionHCS.Web.Models
{
    public class CommunityEngagement
    {
        public int Id { get; set; }

        // Member Information
        [Required]
        [Display(Name = "Member Name")]
        public string MemberName { get; set; }

        [Required]
        [Display(Name = "Member Phone Number")]
        public string MemberPhoneNumber { get; set; }

        // Caregiver Information
        [Required]
        [Display(Name = "Caregiver Name")]
        public string CaregiverName { get; set; }

        [Required]
        [Display(Name = "Caregiver Phone Number")]
        public string CaregiverPhoneNumber { get; set; }

        // Staff Information
        [Required]
        [Display(Name = "Staff Name")]
        public string StaffName { get; set; }

        [Required]
        [Display(Name = "Staff ID")]
        public string StaffId { get; set; }

        // Activity Information
        [Display(Name = "Community Activity")]
        public string? CommunityActivity { get; set; }

        public string? Location { get; set; }

        [Display(Name = "Duration (Hours)")]
        [Range(0.1, 24.0, ErrorMessage = "Duration must be between 0.1 and 24 hours.")]
        public decimal? DurationHours { get; set; }

        public string? Participants { get; set; }

        [Display(Name = "Activity Description")]
        public string? ActivityDescription { get; set; }

        // Engagement Details
        [Display(Name = "Member's Response/Engagement")]
        public string? MemberResponse { get; set; }

        public string? Observations { get; set; }

        [Display(Name = "Goals Achieved")]
        public string? GoalsAchieved { get; set; }

        // Follow-up
        [Display(Name = "Follow-up Required")]
        public bool FollowUpRequired { get; set; }

        [Display(Name = "Follow-up Notes")]
        public string? FollowUpNotes { get; set; }

        // Signatures
        [Display(Name = "Staff Signature")]
        public string? StaffSignature { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Signed")]
        public DateTime? DateSigned { get; set; }

        // Supervisor Review
        [Display(Name = "Supervisor Name")]
        public string? SupervisorName { get; set; }

        [Display(Name = "Supervisor Signature")]
        public string? SupervisorSignature { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Supervisor Review Date")]
        public DateTime? SupervisorDate { get; set; }

        [Display(Name = "Supervisor Review Completed")]
        public bool SupervisorReview { get; set; }

        // Additional Comments
        [Display(Name = "Additional Comments")]
        public string? AdditionalComments { get; set; }

        // Audit Fields
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Status { get; set; } = "Draft";
    }
}
