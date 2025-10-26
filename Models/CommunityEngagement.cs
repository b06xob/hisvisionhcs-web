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

        // Weekly Activity Information
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Saturday Date")]
        public DateTime SaturdayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? SaturdayActivity { get; set; }

        public string? SaturdayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool SaturdayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? SaturdayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? SaturdayOutcome { get; set; }

        // Sunday
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Sunday Date")]
        public DateTime SundayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? SundayActivity { get; set; }

        public string? SundayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool SundayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? SundayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? SundayOutcome { get; set; }

        // Monday
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Monday Date")]
        public DateTime MondayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? MondayActivity { get; set; }

        public string? MondayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool MondayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? MondayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? MondayOutcome { get; set; }

        // Tuesday
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Tuesday Date")]
        public DateTime TuesdayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? TuesdayActivity { get; set; }

        public string? TuesdayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool TuesdayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? TuesdayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? TuesdayOutcome { get; set; }

        // Wednesday
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Wednesday Date")]
        public DateTime WednesdayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? WednesdayActivity { get; set; }

        public string? WednesdayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool WednesdayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? WednesdayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? WednesdayOutcome { get; set; }

        // Thursday
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Thursday Date")]
        public DateTime ThursdayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? ThursdayActivity { get; set; }

        public string? ThursdayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool ThursdayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? ThursdayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? ThursdayOutcome { get; set; }

        // Friday
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Friday Date")]
        public DateTime FridayDate { get; set; }

        [Display(Name = "Activity/Event")]
        public string? FridayActivity { get; set; }

        public string? FridayLocation { get; set; }

        [Display(Name = "Transportation Provided")]
        public bool FridayTransportationProvided { get; set; }

        [Display(Name = "Staff Support")]
        public string? FridayStaffSupport { get; set; }

        [Display(Name = "Outcome/Feedback")]
        public string? FridayOutcome { get; set; }

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
