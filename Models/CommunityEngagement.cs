using System.ComponentModel.DataAnnotations;

namespace HisVisionHCS.Web.Models
{
    public class CommunityEngagement
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Member name is required")]
        [Display(Name = "Member Name")]
        public string MemberName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Member ID is required")]
        [Display(Name = "Member ID")]
        public string MemberId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Date is required")]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; } = DateTime.Today;

        [Required(ErrorMessage = "Staff name is required")]
        [Display(Name = "Staff Name")]
        public string StaffName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Staff ID is required")]
        [Display(Name = "Staff ID")]
        public string StaffId { get; set; } = string.Empty;

        [Display(Name = "Community Activity")]
        public string? CommunityActivity { get; set; }

        [Display(Name = "Location")]
        public string? Location { get; set; }

        [Display(Name = "Duration (hours)")]
        [Range(0, 24, ErrorMessage = "Duration must be between 0 and 24 hours")]
        public decimal? DurationHours { get; set; }

        [Display(Name = "Participants")]
        public string? Participants { get; set; }

        [Display(Name = "Activity Description")]
        [DataType(DataType.MultilineText)]
        public string? ActivityDescription { get; set; }

        [Display(Name = "Member's Response/Engagement")]
        [DataType(DataType.MultilineText)]
        public string? MemberResponse { get; set; }

        [Display(Name = "Observations")]
        [DataType(DataType.MultilineText)]
        public string? Observations { get; set; }

        [Display(Name = "Goals Achieved")]
        [DataType(DataType.MultilineText)]
        public string? GoalsAchieved { get; set; }

        [Display(Name = "Follow-up Required")]
        public bool FollowUpRequired { get; set; }

        [Display(Name = "Follow-up Notes")]
        [DataType(DataType.MultilineText)]
        public string? FollowUpNotes { get; set; }

        [Display(Name = "Staff Signature")]
        public string? StaffSignature { get; set; }

        [Display(Name = "Date Signed")]
        [DataType(DataType.Date)]
        public DateTime? DateSigned { get; set; }

        [Display(Name = "Supervisor Review")]
        public bool SupervisorReview { get; set; }

        [Display(Name = "Supervisor Name")]
        public string? SupervisorName { get; set; }

        [Display(Name = "Supervisor Signature")]
        public string? SupervisorSignature { get; set; }

        [Display(Name = "Supervisor Date")]
        [DataType(DataType.Date)]
        public DateTime? SupervisorDate { get; set; }

        [Display(Name = "Additional Comments")]
        [DataType(DataType.MultilineText)]
        public string? AdditionalComments { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
    }
}
